# Library Management System

A desktop-based Library Management System developed using **C# Windows Forms, .NET Framework 4.8, SQL Server, and Entity Framework 6**.

This project was created for educational purposes to practice desktop application development, relational database design, and database-driven application architecture.

## Overview

The application simulates a library management environment with separate interfaces for administrators and customers.

It demonstrates the integration of a Windows Forms user interface with a SQL Server database using Entity Framework.

## Technologies Used

- **Language:** C#
- **Desktop Framework:** Windows Forms (.NET Framework 4.8)
- **Database:** Microsoft SQL Server
- **ORM:** Entity Framework 6 (Database First / EDMX)
- **Development Environment:** Visual Studio

## Application Structure

### Administrator Interface

The project includes dedicated forms for:

- Book management
- Category management
- Customer management
- Order management

### Customer Interface

The project includes dedicated forms for:

- Home page
- Book browsing
- Customer profile
- Order history

### Database

The project includes a SQL Server database script, `LibraryManagementDB.sql`, and an Entity Framework data model.

## Getting Started

1. Clone the repository.
2. Open `LibraryFormProject/LibraryFormProject.slnx` in a compatible version of Visual Studio.
3. Restore the project's NuGet packages.
4. Set up the SQL Server database using `LibraryManagementDB.sql`.
5. Update the database connection string in `App.config` to match your local SQL Server instance.
6. Build and run the application.

## Project Purpose

This project was developed to gain practical experience in:

- C# desktop application development
- SQL Server database integration
- Entity Framework data access
- Windows Forms user interface design
- Organizing a multi-form application

## Project Status

Educational project — developed as a practical library management application.
