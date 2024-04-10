# Premium Attendance
Attendance system build in C# and uses Arduino RFID reader for recording attendance into MSSQL database. It was developed as school final project called "Omega".

## Author
- Name: Maksym Kintor
- Email: kintormaksim@gmail.com
- School: Secondary Technical School of Electrical Engineering
- Grade: C4b

## Technology used
- C# .NET
- MSSQL
- Arduino UNO & RFID reader

## Table of Contents
- [Installation](#installation)
- [Run](#run)
- [Configuration](#configuration)
- [Use Case](#use-case)
- [Test Case](#test-case)
- [Architecture](#architecture)
  - [User tier](#user-tier)
  - [Business tier](#business-tier)
  - [Data tier](#data-tier)
- [E-R diagram](#e-r-diagram)
- [File structure](#file-structure)
- [Errors](#errors)
- [Resume](#resume)


## Installation
```bash
git clone https://github.com/MaksymDoremi/Alpha_Three.git
```

## Run 
Before execution, do the following steps according to [Configuration](#configuration).  
Run by the exact instructions!  
Windows CMD
```bash
cd Alpha_Three/Alpha_Three/bin/Debug/net6.0/

Alpha_Three.exe # execute exe file, or you can just click on it.
```
Git Bash
```bash
cd Alpha_Three/Alpha_Three/bin/Debug/net6.0/

./Alpha_Three.exe # execute exe file, or you can just click on it.
```



## Configuration
1) Before running the program, firstly import database, script you can find at `Alpha_Three/data/export.sql`. Use MSSQL Server Management Studio to do so.
    - You can change the login and password -> if you do so, then you must change it in connectionString. Default is "admin_user" with password "123"

User has access to configure following variables at `Alpha_Three/App.config`
- **skolniConnection** connectionString="Data Source=**PCXXX**;Initial Catalog=Alpha_Three;Persist Security Info=True;User ID=**admin_user**;Password=**123**"  
Connection string to the database. Uses custom user, which is created with database export, **You have to change PCXXX to your PC**.
- **logFilePath** value="../../../errorLogs/log.txt"  
Path where erros are logged, you can change it if you want.
Default is `Alpha_Three/errorLogs/log.txt`.  
You can use relative path or absolute `C:/somewhere`
- **ticketViewReportPath** value="../../../data/ticketReport.txt"  
Path where you get ticket report, default is `Alpha_Three/data/ticketReport.txt`.  
You can use relative path or absolute `C:/somewhere`
- **driveViewReportPath** value="../../../data/driveReport.txt"  
Path where you get drive report, default is `Alpha_Three/data/driveReport.txt`.  
You can use relative path or absolute `C:/somewhere`


## Use Case
User can choose what he wants to do just by typing 1-n numbers => to choose from list of available commands.  
Tables and report sections are accessed through strings "tables" and "report" from Application layer.  
Each CRUD command has its own environment that requires user to provide data needed for operation.

Application
- tables
    - Drive {create, retrieve, update, delete}
    - Passenger {create, retrieve, update, delete, import_json}
    - Station {create, retrieve, update, delete, import_json}
    - Ticket {create, retrieve, update, delete}
    - Track {create, retrieve, update, delete}
    - Train_driver {create, retrieve, update, delete, import_json}
    - Train {create, retrieve, update, delete, import_json}
    - Travel_class {retrieve}
- report
    - DriveReportCommand
    - TicketReportCommand

## Test Case
Test cases you can find at `Alpha_Three/tests/`

## Architecture
Project is developed as three-tier application.
Main functionality is provided by ICommand, BLL(Business Logic Layer) and DAL(Data Access Layer).

### User tier
- Application - first entry point, displays message on the screen, gives access to tables and report sections.  
It's while(True) loop that requires user to type in command he wants to execute, in case of bad command returns "Unknown command". 

### Business tier
- ICommand - interface for other commands, has string Execute(){} method, that each command executes differently.
- TablenameCommand - commands that are entry points to the CRUD commands available for each command. It's while(True) loop, that works on the same principe as Application loop.  
Requires user to type 1-n to execute CRUD command, in case of bad command returns "Unknown command" and execution goes on.
- CRUDTablenameCommand - commands that execute the exact CRUD operation. Requires user to interact, require user to provide data for execution, in case of bad input exception occurs -> user is notified, error logged, and execution terminates, user returns back on TablenameCommand while(True) loop.
- TablenameBLL - business logic layer for each table in the database, it's middleware between application tier and data tier, executes TablenameDAL functions, throws exception to the CRUDTablenamCommand, which catches that exception.

### Data tier
- TablenameDAL - data access layer for each table in the database, directly communicates with database, manipulates with data. Throws exception to the TablenameBLL, which throws that exception to CRUDTablenameCommand.

## E-R diagram
![ER diagram](../Alpha_Three/data/ERdiagram.png "Diagram")

## File structure
<pre>
│   .gitignore
│   Dokumentace.docx
│   Elevator Pitch.docx
│   Elevator Pitch.txt
│   PremiumAttendance.sln
│
├───.github
├───img
│       diagram.png
│       Untitled design.png
│
├───PremiumAttendance
│   │   App.config
│   │   packages.config
│   │   PremiumAttendance.csproj
│   │
│   ├───data
│   ├───doc
│   │       README.md <b>(this file)</b>
│   │
│   ├───errorLogs
│   │       log.txt
│   │
│   ├───Resources
│   ├───src
│   │   │   Program.cs
│   │   │
│   │   ├───Controls
│   │   │       AttendanceFormAttendanceControl.cs
│   │   │       AttendanceFormAttendanceControl.Designer.cs
│   │   │       AttendanceFormAttendanceControl.resx
│   │   │       AttendanceFormEmployeeControl.cs
│   │   │       AttendanceFormEmployeeControl.Designer.cs
│   │   │       AttendanceFormEmployeeControl.resx
│   │   │       ColleagueControl.cs
│   │   │       ColleagueControl.Designer.cs
│   │   │       ColleagueControl.resx
│   │   │       EmployeeControl.cs
│   │   │       EmployeeControl.Designer.cs
│   │   │       EmployeeControl.resx
│   │   │       EmployeeStatusControl.cs
│   │   │       EmployeeStatusControl.Designer.cs
│   │   │       EmployeeStatusControl.resx
│   │   │       NotificationControl.cs
│   │   │       NotificationControl.Designer.cs
│   │   │       NotificationControl.resx
│   │   │
│   │   ├───DB
│   │   │       DatabaseConnection.cs
│   │   │
│   │   ├───Forms
│   │   │   │   DashBoardForm.cs
│   │   │   │   DashBoardForm.Designer.cs
│   │   │   │   DashBoardForm.resx
│   │   │   │   LoginForm.cs
│   │   │   │   LoginForm.Designer.cs
│   │   │   │   LoginForm.resx
│   │   │   │
│   │   │   ├───SidebarForms
│   │   │   │       AttendanceForm.cs
│   │   │   │       AttendanceForm.Designer.cs
│   │   │   │       AttendanceForm.resx
│   │   │   │       EmployeesForm.cs
│   │   │   │       EmployeesForm.Designer.cs
│   │   │   │       EmployeesForm.resx
│   │   │   │       HomepageForm.cs
│   │   │   │       HomepageForm.Designer.cs
│   │   │   │       HomepageForm.resx
│   │   │   │       MyAccountForm.cs
│   │   │   │       MyAccountForm.Designer.cs
│   │   │   │       MyAccountForm.resx
│   │   │   │       MyDashboardForm.cs
│   │   │   │       MyDashboardForm.Designer.cs
│   │   │   │       MyDashboardForm.resx
│   │   │   │       NotificationForm.cs
│   │   │   │       NotificationForm.Designer.cs
│   │   │   │       NotificationForm.resx
│   │   │   │
│   │   │   └───SubForms
│   │   │           AddEmployeeForm.cs
│   │   │           AddEmployeeForm.Designer.cs
│   │   │           AddEmployeeForm.resx
│   │   │           ChangePasswordForm.cs
│   │   │           ChangePasswordForm.Designer.cs
│   │   │           ChangePasswordForm.resx
│   │   │           CustomizeAccountForm.cs
│   │   │           CustomizeAccountForm.Designer.cs
│   │   │           CustomizeAccountForm.resx
│   │   │           EmployeeAccount.cs
│   │   │           EmployeeAccount.Designer.cs
│   │   │           EmployeeAccount.resx
│   │   │           NotificationDetailsForm.cs
│   │   │           NotificationDetailsForm.Designer.cs
│   │   │           NotificationDetailsForm.resx
│   │   │           SendNotificationForm.cs
│   │   │           SendNotificationForm.Designer.cs
│   │   │           SendNotificationForm.resx
│   │   │
│   │   └───Objects
│   │       │   APIClient.cs
│   │       │   BusinessLogicLayer.cs
│   │       │   Employee.cs
│   │       │   Logger.cs
│   │       │   Notification.cs
│   │       │   RFID.cs
│   │       │   SvatkyAPIObject.cs
│   │       │
│   │       └───DataAccessLayer
│   │               CreateDataAccessLayer.cs
│   │               DeleteDataAccessLayer.cs
│   │               RetrieveDataAccessLayer.cs
│   │               UpdateDataAccessLayer.cs
│   │
│   ├───tests
│   └───vendor
│           ComponentFactory.Krypton.Design.dll
│           ComponentFactory.Krypton.Design.pdb
│           ComponentFactory.Krypton.Docking.dll
│           ComponentFactory.Krypton.Docking.pdb
│           ComponentFactory.Krypton.Navigator.dll
│           ComponentFactory.Krypton.Navigator.pdb
│           ComponentFactory.Krypton.Ribbon.dll
│           ComponentFactory.Krypton.Ribbon.pdb
│           ComponentFactory.Krypton.Toolkit.dll
│           ComponentFactory.Krypton.Toolkit.pdb
│           ComponentFactory.Krypton.Workspace.dll
│           ComponentFactory.Krypton.Workspace.pdb
│
└───sql
        script.sql
</pre>

## Errors
There might be wrong connection string or some issues, in that case application will try to connect 3 more times with interval 2 seconds, if still can't then it's shutdown.  
You can find errors at `Alpha_Three/errorLogs/log.txt`

Application handles DML errors, in case of error -> notify uses and log error, with those errors application may continue to run without issues.

## Resume
This project was developed as school task in order to teach students how to work on bigger solutions.  
That definitely gonna teach students to think in advance and try to design better and inteligent projects.  
This project can be used as educational content in schools.  