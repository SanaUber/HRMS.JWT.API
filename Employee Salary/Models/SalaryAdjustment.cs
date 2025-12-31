using System.ComponentModel.DataAnnotations;

namespace Employee_Salary.Models
{
    public class SalaryAdjustment
    {
        [Key] public int Docno { get; set; }
        public string EmployeeID { get; set; } = null!;
        public decimal SalaryIncrement { get; set; }
        public DateTime WEF { get; set; }
        public Employee Employee { get; set; }
 

    }
}
