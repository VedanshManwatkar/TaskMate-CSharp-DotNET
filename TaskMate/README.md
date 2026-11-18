# TaskMate – Task Management System

TaskMate is a desktop-based Task Management System developed using C# Windows Forms and Oracle Database. It helps users organize, manage, and track their daily, important, and planned tasks through a simple graphical user interface.

## Features

- **Login System:** Login interface for user access.
- **User Registration:** Registration form with input validation.
- **My Day:** Manage daily tasks.
- **Important Tasks:** Store and manage important tasks.
- **Planned Tasks:** Organize future tasks.
- **All Tasks:** View tasks from different categories.
- **Task Management:** Insert, update, delete, and view tasks.
- **Task Status:** Track tasks as Pending or Completed.
- **Oracle Database:** Store and retrieve task information.

## Technologies Used

- C#
- .NET 8.0 Windows Forms
- Oracle Database
- Oracle Managed Data Access
- Visual Studio

## Project Structure

```text
TaskMate/
│
├── README.md
├── .gitignore
├── TaskMate.sln
│
├── Database/
│   └── TaskMate_Database.sql
│
└── TaskMate/
    ├── TaskMate.csproj
    ├── Program.cs
    ├── Form1.cs
    ├── FrmLogin.cs
    ├── FrmRegister.cs
    ├── Menu.cs
    ├── MyDay.cs
    ├── Important.cs
    ├── Planned.cs
    ├── Task.cs
    └── Properties/
```

The project also includes the corresponding Designer and resource files for the Windows Forms screens.

## Database Setup

This project uses Oracle Database.

1. Open Oracle SQL Developer.
2. Connect to your Oracle database.
3. Open `Database/TaskMate_Database.sql`.
4. Execute the SQL script.
5. The script creates the following tables:

   - `myday`
   - `important`
   - `planned`
   - `task`

6. Sample task records are inserted into the MyDay, Important, and Planned tables.

## How to Run the Project

1. Install Visual Studio.
2. Install the .NET 8.0 Windows Desktop development workload.
3. Install and configure Oracle Database.
4. Clone or download this repository.
5. Open `TaskMate.sln` in Visual Studio.
6. Restore the NuGet packages.
7. Configure your Oracle database connection string in the application.
8. Build and run the project.

**Note:** Update the database connection details according to your local Oracle installation. Do not upload real database passwords or private credentials to GitHub.

## Application Modules

| Module | Description |
|---|---|
| Form1 | Splash Screen |
| FrmLogin | User Login |
| FrmRegister | User Registration |
| Menu | Main Dashboard |
| MyDay | Daily Task Management |
| Important | Important Task Management |
| Planned | Planned Task Management |
| Task | All Tasks |

## Database Tables

| Table Name | Purpose |
|---|---|
| myday | Stores daily tasks |
| important | Stores important tasks |
| planned | Stores planned tasks |
| task | Stores general task records |

## Developer

**Project Name:** TaskMate  
**Project Type:** Desktop Application  
**Language:** C#  
**Database:** Oracle Database

---

*TaskMate – Organize your tasks, manage your time, and stay productive.*