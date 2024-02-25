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
