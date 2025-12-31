using Employee_Salary.Data;
using Employee_Salary.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Employee_Salary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] // Token required only logged in user  can use
    public class DesignationController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DesignationController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/Designation
        [HttpPost]
        public async Task<IActionResult> CreateDesignation([FromBody] Designation designation)
        {
            if (designation == null)
            {
                return BadRequest(new { message = "Designation data is required" });
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Check if DesignationID already exists  
            var exists = await _context.Designation
                .AnyAsync(d => d.DesignationID == designation.DesignationID);

            if (exists)
            {
                return Conflict(new { message = "DesignationID already exists" });
            }

            _context.Designation.Add(designation);
            await _context.SaveChangesAsync();

            return Ok("Designation created successfully");
        }

         
    }
}