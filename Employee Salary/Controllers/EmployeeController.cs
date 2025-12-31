using Employee_Salary.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Employee_Salary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{employeeID}")]
        public async Task<IActionResult> GetMyDetails(string employeeID)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { message = "Invalid token" });
            }

            // Manual join: Employee + Designation + SalaryAdjustments + SalaryApprovals
            var employeeData = await _context.Employee
                .Where(e => e.EmployeeID == employeeID)
                .Join(_context.Designation,
                    e => e.DesignationID,
                    d => d.DesignationID,
                    (e, d) => new { e, d })
                .GroupJoin(_context.SalaryAdjustments,
                    ed => ed.e.EmployeeID,
                    sa => sa.EmployeeID,
                    (ed, adjustments) => new { ed.e, ed.d, adjustments })
                .SelectMany(ed => ed.adjustments.DefaultIfEmpty(), (ed, sa) => new { ed.e, ed.d, sa })
                .GroupJoin(_context.SalaryApproval,
                    eds => new { eds.sa.EmployeeID, eds.sa.Docno },
                    appr => new { appr.EmployeeID, appr.Docno },
                    (eds, approvals) => new { eds.e, eds.d, eds.sa, approvals })
                .SelectMany(eds => eds.approvals.DefaultIfEmpty(), (eds, appr) => new
                {
                    employeeid = eds.e.EmployeeID,
                    Ename = eds.e.EName,
                    designation = eds.d.DesignationName,
                    Docno = eds.sa != null ? eds.sa.Docno : (int?)null,
                    Wef = eds.sa != null ? eds.sa.WEF.ToString("dd/MM/yyyy") : null,
                    SalaryIncrement = eds.sa != null ? eds.sa.SalaryIncrement : (decimal?)null,
                    approvedby = appr != null ? appr.ApprovedBy : null,
                    approvedon = appr != null ? appr.ApprovedOn.ToString("dd/MM/yyyy") : null
                })
                .ToListAsync();

            if (!employeeData.Any())
            {
                return NotFound(new { message = "Employee not found" });
            }

            // Group karke nested JSON banao (exactly note jaisa)
            var result = employeeData
                .GroupBy(x => new { x.employeeid, x.Ename, x.designation })
                .Select(g => new
                {
                    employeeid = g.Key.employeeid,
                    Ename = g.Key.Ename,
                    Designations = new { designation = g.Key.designation },
                    SalaryDetails = g
                        .Where(x => x.Docno != null)
                        .Select(x => new
                        {
                            Docno = x.Docno,
                            EmployeeID = g.Key.employeeid,
                            Wef = x.Wef,
                            SalaryIncrement = x.SalaryIncrement
                        })
                        .OrderBy(sd => sd.Docno)
                        .ToList(),
                    SalaryApprovals = g
                        .Where(x => x.approvedby != null)
                        .Select(x => new
                        {
                            employeeid = g.Key.employeeid,
                            approvedby = x.approvedby,
                            approvedon = x.approvedon
                        })
                        .OrderBy(app => app.approvedon)
                        .ToList()
                })
                .FirstOrDefault();

            return Ok(result);
        }
    }
}