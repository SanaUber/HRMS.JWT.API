# HRMS.JWT.API
  Secure ASP.NET Core Web API for a basic Human Resource Management System focusing on employee salary adjustment workflow.
# Project Objective
Sqlserver: 172.16.101.4
Username: Sa
Password : 123

Create database Employees

Table: LoginUser (userid, password)
Table: Employees (EmployeeID, EName, DesignationID)
Table: Designations (DesignationID, DesignationName)
Table: SalaryAdjustments (Docno, EmployeeID, SalaryIncrement, WEF) (Add minimum 10 Records)
Table SalaryApprovals (Employeeid, approvedby, docno, approvedon)

SQL Scripts
Prepare Select Statement

//OutPut secure WebAPI ASP.net (Token Based and Rolewise access)

1.Login
2.Get Employees with Single Statement, produce below json script USING “LINQ”

{
“employeeID”: “abc”
“Ename”: “abcemployee”
Designations:{ “designation” : “Document controller”}
SalaryDetails:{ Docno: 1, “EmployeeID”: “abc”, Wef:“01/10/1900” }
Salaryapprovals:[
{“employeeid” , “abc”, “approvedby”: “projectmanager” , “approvedon” : 01/011900},
{“employeeid” , “abc”, “approvedby”: “projectmanager” , “approvedon” : 01/011900},
{“employeeid” , “abc”, “approvedby”: “projectmanager” , “approvedon” : 01/011900},
{“employeeid” , “abc”, “approvedby”: “projectmanager” , “approvedon” : 01/011900},
{“employeeid” , “abc”, “approvedby”: “projectmanager” , “approvedon” : 01/011900}
]
}

3.Post Method create Designations
## Features

- **JWT Token-Based Authentication** – Login returns JWT with claims (UserId, Name, Designation)
- **Secure Employee Details** – GET `/api/Employee/{employeeID}` returns nested JSON:
  - Employee info & designation
  - Salary Adjustments (with effective date and increment)
  - Salary Approvals (approved by whom and when)
- **Authorization** – 
  - Regular employees can view only their own data and other when got authorized
  - Project Manager ("def") can view any employee's data
- **Designation Management** – POST `/api/Designation` to create new designations
- **EF Core Code-First** – Database created via migrations with seeded data (minimum 10 salary adjustment records)
- **Manual LINQ Joins** – Complex nested query without navigation properties

## Tech Stack

- .NET 8 ASP.NET Core Web API
- Entity Framework Core (Code-First)
- JWT Authentication
- SQL Server (LocalDB/SQL Express)

## Database Schema

- LoginUser, Employee, Designation, SalaryAdjustment, SalaryApproval
- Seeded data:
  - Employees: "abc" (Document Controller), "def" (Project Manager)
  - 10 Salary Adjustments + 10 Approvals for "abc" (approved by "def")

## API Endpoints

| Method | Endpoint                     | Description                          | Auth |
|--------|------------------------------|--------------------------------------|------|
| POST   | `/api/Auth/login`            | Get JWT token                        | No   |
| GET    | `/api/Employee/{employeeID}` | Get employee details (nested)        | Yes  |
| POST   | `/api/Designation`           | Create new designation               | Yes  |

## How to Run

1. Clone repo
   ```bash
   git clone https://github.com/yourusername/HRMS.JWT.API.git
   cd HRMS.JWT.API






















MethodEndpointDescription
