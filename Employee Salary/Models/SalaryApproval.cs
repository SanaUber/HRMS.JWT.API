 using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee_Salary.Models
{
    public class SalaryApproval
    {
        [Key]
        public int Id { get; set; }
        public string EmployeeID { get; set; }

        [ForeignKey("SalaryAdjustment")]
        public int Docno { get; set; }

        public string ApprovedBy { get; set; } 
        public DateTime ApprovedOn { get; set; } = DateTime.Now;

        // Navigation properties 
        public Employee Employee { get; set; }  
        public SalaryAdjustment SalaryAdjustment { get; set; } 
    }
}
