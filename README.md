# HRMS.JWT.API
HRMS.JWT.API
Project Overview
HRMS.JWT.API is a secure ASP.NET Core Web API for a basic Human Resource Management System (HRMS) with a focus on employee salary adjustment workflow.
This API implements:

Token-based authentication using JWT (JSON Web Tokens)
Secure employee details retrieval with nested salary adjustments and approvals
Role-based access (Project Manager can view other employees' data)
CRUD operations (e.g., create new designations)
Data seeding via EF Core migrations (including minimum 10 salary adjustment records)

The project follows real-world practices like manual LINQ joins, secure endpoints, and clean architecture.
Key Features

JWT Authentication – Login endpoint returns JWT token with claims (UserId, Name, Designation)
Secure Employee Details – GET endpoint returns nested JSON with:
Employee info
Designation
Salary Adjustments (with WEF and increment)
Salary Approvals (approved by whom and when)

Authorization – Users can view only their own data. Project Manager ("def") can view any employee's data
Designation Management – POST endpoint to create new designations
EF Core Code-First – Database created via migrations with seeded data
Manual LINQ Joins – Complex query without navigation properties for better control

Tech Stack

.NET 8 (ASP.NET Core Web API)
Entity Framework Core (Code-First with migrations)
JWT Authentication (Microsoft.AspNetCore.Authentication.JwtBearer)
SQL Server (LocalDB or SQL Express)

Database Schema

LoginUser – UserId (PK), Password (plain text for demo – hash in production)
Designation – DesignationID (PK), DesignationName
Employee – EmployeeID (PK), EName, DesignationID (FK)
SalaryAdjustment – Docno (PK), EmployeeID (FK), SalaryIncrement, WEF
SalaryApproval – Id (PK), EmployeeID + Docno (composite FK), ApprovedBy, ApprovedOn

Seeded data includes:

Employees: "abc" (Document Controller), "def" (Project Manager)
10 Salary Adjustments for "abc"
10 corresponding Salary Approvals (approved by "def")

API Endpoints





























MethodEndpointDescription
