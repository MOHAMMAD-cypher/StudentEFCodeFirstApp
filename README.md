# StudentEFCodeFirstApp
This repository is for my assignment
# StudentEFCodeFirstApp

A basic Entity Framework Code-First console application written in C#.

## Features

- Defines a `Student` model class
- Uses `SchoolContext` for EF Core database operations
- Automatically creates the database and adds a student record

## Technologies

- .NET Core / .NET SDK
- Entity Framework Core
- SQL Server LocalDB

## How It Works

On running the application:

1. The database `StudentDB` is created (if it doesn't exist).
2. A student named **John Doe** is added to the `Students` table.
3. A message is printed to the console confirming the operation.

## Setup Instructions

> Make sure you have .NET 6.0+ SDK and SQL Server LocalDB installed.

```bash
dotnet restore
dotnet run
