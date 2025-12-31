using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Employee_Salary.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Designation",
                columns: new[] { "DesignationID", "DesignationName" },
                values: new object[,]
                {
                    { "DC", "Document Controller" },
                    { "PM", "Project Manager" }
                });

            migrationBuilder.InsertData(
                table: "LoginUser",
                columns: new[] { "UserId", "Password" },
                values: new object[,]
                {
                    { "abc", "abc123" },
                    { "def", "def123" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "DesignationID", "EName" },
                values: new object[,]
                {
                    { "abc", "DC", "abcemployee" },
                    { "def", "PM", "defemployee" }
                });

            migrationBuilder.InsertData(
                table: "SalaryAdjustments",
                columns: new[] { "Docno", "EmployeeID", "SalaryIncrement", "WEF" },
                values: new object[,]
                {
                    { 1, "abc", 5000m, new DateTime(1900, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "abc", 3000m, new DateTime(1900, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "abc", 4000m, new DateTime(1900, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "abc", 2500m, new DateTime(1901, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "abc", 3500m, new DateTime(1901, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "abc", 6000m, new DateTime(1901, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "abc", 4500m, new DateTime(1901, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "abc", 5500m, new DateTime(1901, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "abc", 7000m, new DateTime(1901, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "abc", 8000m, new DateTime(1901, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SalaryApproval",
                columns: new[] { "Id", "ApprovedBy", "ApprovedOn", "Docno", "EmployeeID" },
                values: new object[,]
                {
                    { 1, "def", new DateTime(1900, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "abc" },
                    { 2, "def", new DateTime(1900, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "abc" },
                    { 3, "def", new DateTime(1900, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "abc" },
                    { 4, "def", new DateTime(1901, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "abc" },
                    { 5, "def", new DateTime(1901, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "abc" },
                    { 6, "def", new DateTime(1901, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "abc" },
                    { 7, "def", new DateTime(1901, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "abc" },
                    { 8, "def", new DateTime(1901, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "abc" },
                    { 9, "def", new DateTime(1901, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "abc" },
                    { 10, "def", new DateTime(1901, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "abc" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: "def");

            migrationBuilder.DeleteData(
                table: "LoginUser",
                keyColumn: "UserId",
                keyValue: "abc");

            migrationBuilder.DeleteData(
                table: "LoginUser",
                keyColumn: "UserId",
                keyValue: "def");

            migrationBuilder.DeleteData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SalaryApproval",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Designation",
                keyColumn: "DesignationID",
                keyValue: "PM");

            migrationBuilder.DeleteData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SalaryAdjustments",
                keyColumn: "Docno",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: "abc");

            migrationBuilder.DeleteData(
                table: "Designation",
                keyColumn: "DesignationID",
                keyValue: "DC");
        }
    }
}
