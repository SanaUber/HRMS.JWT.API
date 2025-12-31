using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee_Salary.Migrations
{
    /// <inheritdoc />
    public partial class SeedThirdData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 4,
                column: "ApprovedBy",
                value: "abc");

            migrationBuilder.UpdateData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApprovedBy", "EmployeeID" },
                values: new object[] { "abc", "def" });

            migrationBuilder.UpdateData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ApprovedBy", "EmployeeID" },
                values: new object[] { "abc", "def" });

            migrationBuilder.UpdateData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ApprovedBy", "EmployeeID" },
                values: new object[] { "abc", "def" });

            migrationBuilder.UpdateData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ApprovedBy", "EmployeeID" },
                values: new object[] { "abc", "ghi" });

            migrationBuilder.UpdateData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ApprovedBy", "EmployeeID" },
                values: new object[] { "abc", "ghi" });

            migrationBuilder.UpdateData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ApprovedBy", "EmployeeID" },
                values: new object[] { "abc", "ghi" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 4,
                column: "ApprovedBy",
                value: "def");

            migrationBuilder.UpdateData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApprovedBy", "EmployeeID" },
                values: new object[] { "def", "abc" });

            migrationBuilder.UpdateData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ApprovedBy", "EmployeeID" },
                values: new object[] { "def", "abc" });

            migrationBuilder.UpdateData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ApprovedBy", "EmployeeID" },
                values: new object[] { "def", "abc" });

            migrationBuilder.UpdateData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ApprovedBy", "EmployeeID" },
                values: new object[] { "def", "abc" });

            migrationBuilder.UpdateData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ApprovedBy", "EmployeeID" },
                values: new object[] { "def", "abc" });

            migrationBuilder.UpdateData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ApprovedBy", "EmployeeID" },
                values: new object[] { "def", "abc" });
        }
    }
}
