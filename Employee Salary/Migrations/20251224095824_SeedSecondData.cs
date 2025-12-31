using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee_Salary.Migrations
{
    /// <inheritdoc />
    public partial class SeedSecondData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: "abc",
                column: "EName",
                value: "Elon");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: "def",
                column: "EName",
                value: "Bill");

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "DesignationID", "EName" },
                values: new object[] { "ghi", "PM", "Mark" });

            migrationBuilder.UpdateData(
                table: "LoginUser",
                keyColumn: "UserId",
                keyValue: "abc",
                column: "Password",
                value: "passord123");

            migrationBuilder.UpdateData(
                table: "LoginUser",
                keyColumn: "UserId",
                keyValue: "def",
                column: "Password",
                value: "passord123");

            migrationBuilder.UpdateData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 5,
                column: "EmployeeID",
                value: "def");

            migrationBuilder.UpdateData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 6,
                column: "EmployeeID",
                value: "def");

            migrationBuilder.UpdateData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 7,
                column: "EmployeeID",
                value: "def");

            migrationBuilder.UpdateData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 8,
                column: "EmployeeID",
                value: "ghi");

            migrationBuilder.UpdateData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 9,
                column: "EmployeeID",
                value: "ghi");

            migrationBuilder.UpdateData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 10,
                column: "EmployeeID",
                value: "ghi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: "ghi");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: "abc",
                column: "EName",
                value: "abcemployee");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: "def",
                column: "EName",
                value: "defemployee");

            migrationBuilder.UpdateData(
                table: "LoginUser",
                keyColumn: "UserId",
                keyValue: "abc",
                column: "Password",
                value: "abc123");

            migrationBuilder.UpdateData(
                table: "LoginUser",
                keyColumn: "UserId",
                keyValue: "def",
                column: "Password",
                value: "def123");

            migrationBuilder.UpdateData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 5,
                column: "EmployeeID",
                value: "abc");

            migrationBuilder.UpdateData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 6,
                column: "EmployeeID",
                value: "abc");

            migrationBuilder.UpdateData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 7,
                column: "EmployeeID",
                value: "abc");

            migrationBuilder.UpdateData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 8,
                column: "EmployeeID",
                value: "abc");

            migrationBuilder.UpdateData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 9,
                column: "EmployeeID",
                value: "abc");

            migrationBuilder.UpdateData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 10,
                column: "EmployeeID",
                value: "abc");
        }
    }
}
