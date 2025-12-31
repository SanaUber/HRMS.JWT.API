using System.ComponentModel.DataAnnotations;

namespace Employee_Salary.Models
{
    public class Employee
    {
        [Key] public string EmployeeID { get; set; }  
        public string EName { get; set; }  
        public string DesignationID { get; set; }
        public Designation Designation { get; set; }
      }
}
