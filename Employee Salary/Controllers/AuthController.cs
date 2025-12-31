
using Employee_Salary.Data;
using Employee_Salary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Employee_Salary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            // 1. Database user check 
            var user = await _context.LoginUser
                .FirstOrDefaultAsync(u => u.UserId == request.UserId && u.Password == request.Password);

            if (user == null)
            {
                return Unauthorized(new { message = "Invalid credentials" });
            }

            // 2. Employee   data  
            var employee = await _context.Employee
                .Include(e => e.Designation)
                .FirstOrDefaultAsync(e => e.EmployeeID == user.UserId);

            // 3. Claims  
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId),
                new Claim(ClaimTypes.Name, employee?.EName ?? "User"),
                new Claim("Designation", employee?.Designation?.DesignationName ?? "Employee")
            };
              // 4. JWT Token generate
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(double.Parse(_configuration["Jwt:ExpiryMinutes"]!)),
                signingCredentials: creds);

            var tokenHandler = new JwtSecurityTokenHandler();

            return Ok(new
            {
                token = tokenHandler.WriteToken(token),
                expiry = token.ValidTo,
                userId = user.UserId,
                name = employee?.EName,
                designation = employee?.Designation?.DesignationName
            });
        }
    }

    public class LoginRequest
    {
        public string UserId { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}