# TaskFullStack

TaskFullStack is a sample ASP.NET Core MVC application for managing articles. It includes features for CRUD operations on articles, role-based authorization, error handling, and logging.

## Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- SQL Server (or another supported database)

## Getting Started

**Clone the repository:**

   ```bash
   git clone https://github.com/your-username/TaskFullStack.git

 ```bash
    cd TaskFullStack
Restore dependencies and build the project:

 ```bash
  dotnet restore
  dotnet build

Update the database with Entity Framework Core migrations:

 ```bash
  dotnet ef database update

Run the application:

 ```bash
  dotnet run



# SQL Script: Create Items Table

## Description

This SQL script creates a table named "Items" in the "Task" database. The table contains columns for ID, Name, Category, and Price.

## Database Setup

1. Ensure you have Microsoft SQL Server Management Studio (SSMS) installed.
2. Open SSMS and connect to your SQL Server instance.

## Usage

1. Open SSMS and connect to the "Task" database.
2. Copy the SQL script provided below.
3. Open a new query window in SSMS.
4. Paste the SQL script into the query window.
5. Execute the script to create the "Items" table.

## SQL Script

```sql
CREATE TABLE Items (
    ID INT PRIMARY KEY,
    Name NVARCHAR(100),
    Category NVARCHAR(50),
    Price DECIMAL(10, 2)
);
