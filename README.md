# Library Management System

A desktop-based library management application developed using **C#, Windows Forms, .NET Framework 4.8, SQL Server, and Entity Framework 6**.

This educational project simulates a library management environment with role-based authentication, administrative CRUD operations, customer book ordering, and relational database integration.

## Overview

The Library Management System provides two distinct user interfaces: **Administrator** and **Customer**.

After logging in, users are directed to the appropriate interface based on their assigned role.

The application demonstrates the development of a database-driven desktop application using Windows Forms and Entity Framework.

## Technologies Used

- **Programming Language:** C#
- **Framework:** .NET Framework 4.8
- **User Interface:** Windows Forms
- **Database:** Microsoft SQL Server
- **ORM:** Entity Framework 6 (Database First / EDMX)
- **IDE:** Visual Studio
- **Database Connectivity:** ADO.NET / Entity Framework

## Key Features

### Authentication and Role-Based Navigation

- Login functionality for administrators and customers
- Separate user interfaces based on account roles
- Role-based navigation after successful login

### Administrator Features

- **Book Management (CRUD):** Add, view, update, and delete books.
- **Category Management (CRUD):** Create, view, update, and delete book categories.
- **Customer Management (CRUD):** Add, view, edit, and remove customer records.
- **Order Management (CRUD):** Create, view, update, and delete library orders.

### Customer Features

- **Book Browsing:** View available books.
- **Book Ordering:** Create book orders.
- **Order History:** View personal orders.
- **Profile Management:** View and update personal information.
- **Customer Dashboard:** Access customer-specific application features.

## Database Design

The application uses Microsoft SQL Server as its relational database.

The project contains database models and entities related to:

- Books
- Authors
- Book categories
- Publishers
- Physical book records
- Customers
- Administrators
- Orders
- Book-author relationships

Entity Framework 6 is used to interact with the database through an EDMX-based data model.

The repository includes `LibraryManagementDB.sql` for database setup.

## Project Structure

```text
LibraryManagmentProject/
├── LibraryFormProject/
│   ├── LibraryFormProject.slnx
│   └── LibraryFormProject/
│       ├── Admin/
│       ├── Customer/
│       ├── Properties/
│       ├── App.config
│       ├── LibraryFormProject.csproj
│       ├── Model1.edmx
│       └── Program.cs
├── LibraryManagementDB.sql
├── .gitignore
└── README.md
```

## Installation and Setup

1. Clone the repository.
2. Open `LibraryFormProject/LibraryFormProject.slnx` in a compatible version of Visual Studio.
3. Restore the required NuGet packages.
4. Set up the SQL Server database using `LibraryManagementDB.sql`.
5. Update the connection string in `App.config` according to your local SQL Server configuration.
6. Build and run the application.
7. Log in with an account configured in the local database.

## Learning Outcomes

This project provided practical experience in:

- C# desktop application development
- Windows Forms interface design
- CRUD operations and database management
- SQL Server integration
- Entity Framework Database First development
- Role-based application navigation
- Relational database modeling
- Organizing multi-form desktop applications

## Project Purpose

This application was developed for educational purposes to strengthen practical software development skills and explore database-driven desktop application architecture.

## Project Status

Completed educational project.
