using System.ComponentModel.DataAnnotations;

namespace Employee_Salary.Models
{
    public class LoginUser
    {
        [Key] public string UserId { get; set; }
        public string Password { get; set; }
    }
}
