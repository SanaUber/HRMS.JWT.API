using System.ComponentModel.DataAnnotations;

namespace Employee_Salary.Models
{
    public class Designation
    {
        [Key] public string DesignationID { get; set; } 
        public string DesignationName { get; set; }  
    }
}
