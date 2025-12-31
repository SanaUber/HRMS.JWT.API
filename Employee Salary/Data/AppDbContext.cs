using Employee_Salary.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Salary.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions dbcontextoptions) : base(dbcontextoptions) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Designations
            modelBuilder.Entity<Designation>().HasData(
                new Designation { DesignationID = "DC", DesignationName = "Document Controller" },
                new Designation { DesignationID = "PM", DesignationName = "Project Manager" }
            );

            // Employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeID = "abc", EName = "Elon", DesignationID = "DC" },
                new Employee { EmployeeID = "def", EName = "Bill", DesignationID = "PM" },
                new Employee { EmployeeID = "ghi", EName = "Mark", DesignationID = "PM" }
            );

            // SalaryAdjustments - 10 records  
            modelBuilder.Entity<SalaryAdjustment>().HasData(
                new SalaryAdjustment { Docno = 1, EmployeeID = "abc", SalaryIncrement = 5000m, WEF = new DateTime(1900, 10, 1) },
                new SalaryAdjustment { Docno = 2, EmployeeID = "abc", SalaryIncrement = 3000m, WEF = new DateTime(1900, 11, 1) },
                new SalaryAdjustment { Docno = 3, EmployeeID = "abc", SalaryIncrement = 4000m, WEF = new DateTime(1900, 12, 1) },
                new SalaryAdjustment { Docno = 4, EmployeeID = "abc", SalaryIncrement = 2500m, WEF = new DateTime(1901, 1, 1) },
                new SalaryAdjustment { Docno = 5, EmployeeID = "def", SalaryIncrement = 3500m, WEF = new DateTime(1901, 2, 1) },
                new SalaryAdjustment { Docno = 6, EmployeeID = "def", SalaryIncrement = 6000m, WEF = new DateTime(1901, 3, 1) },
                new SalaryAdjustment { Docno = 7, EmployeeID = "def", SalaryIncrement = 4500m, WEF = new DateTime(1901, 4, 1) },
                new SalaryAdjustment { Docno = 8, EmployeeID = "ghi", SalaryIncrement = 5500m, WEF = new DateTime(1901, 5, 1) },
                new SalaryAdjustment { Docno = 9, EmployeeID = "ghi", SalaryIncrement = 7000m, WEF = new DateTime(1901, 6, 1) },
                new SalaryAdjustment { Docno = 10, EmployeeID = "ghi", SalaryIncrement = 8000m, WEF = new DateTime(1901, 7, 1) }
            );

            // SalaryApprovals  
            modelBuilder.Entity<SalaryApproval>().HasData(
                new SalaryApproval { Id = 1, EmployeeID = "abc", Docno = 1, ApprovedBy = "def", ApprovedOn = new DateTime(1900, 10, 10) },
                new SalaryApproval { Id = 2, EmployeeID = "abc", Docno = 2, ApprovedBy = "def", ApprovedOn = new DateTime(1900, 11, 10) },
                new SalaryApproval { Id = 3, EmployeeID = "abc", Docno = 3, ApprovedBy = "def", ApprovedOn = new DateTime(1900, 12, 10) },
                new SalaryApproval { Id = 4, EmployeeID = "abc", Docno = 4, ApprovedBy = "abc", ApprovedOn = new DateTime(1901, 1, 10) },
                new SalaryApproval { Id = 5, EmployeeID = "def", Docno = 5, ApprovedBy = "abc", ApprovedOn = new DateTime(1901, 2, 10) },
                new SalaryApproval { Id = 6, EmployeeID = "def", Docno = 6, ApprovedBy = "abc", ApprovedOn = new DateTime(1901, 3, 10) },
                new SalaryApproval { Id = 7, EmployeeID = "def", Docno = 7, ApprovedBy = "abc", ApprovedOn = new DateTime(1901, 4, 10) },
                new SalaryApproval { Id = 8, EmployeeID = "ghi", Docno = 8, ApprovedBy = "abc", ApprovedOn = new DateTime(1901, 5, 10) },
                new SalaryApproval { Id = 9, EmployeeID = "ghi", Docno = 9, ApprovedBy = "abc", ApprovedOn = new DateTime(1901, 6, 10) },
                new SalaryApproval { Id = 10, EmployeeID = "ghi", Docno = 10, ApprovedBy = "abc", ApprovedOn = new DateTime(1901, 7, 10) }
            );

            // LoginUsers
            modelBuilder.Entity<LoginUser>().HasData(
                new LoginUser { UserId = "abc", Password = "passord123" },
                new LoginUser { UserId = "def", Password = "passord123" },
                new LoginUser { UserId = "ghi", Password = "passord123" }
            );

            base.OnModelCreating(modelBuilder);
        }
       
        
        
        public DbSet <Designation> Designation { get; set; }
        public DbSet <Employee> Employee { get; set; }
        public DbSet <LoginUser> LoginUser { get; set; }
        public DbSet <SalaryAdjustment> SalaryAdjustments { get; set; }
        public DbSet<SalaryApproval> SalaryApproval { get; set; }


    }
}
