use master

drop database if exists PremiumAttendance;

create database PremiumAttendance

use PremiumAttendance

begin transaction;

create table Employee_Role
(
	ID int primary key identity(1,1),
	Role_name varchar(64) not null unique
);

insert into Employee_Role(Role_name)
values('Administrator'),('Employee');

create table Employee
(
	ID int primary key identity(1,1),
	RFID_Tag varchar(64) null default null,  
	Employee_Role_ID int foreign key references Employee_Role(ID) not null,
	[Login] varchar(30) unique not null,
	[Password] varchar(64) not null,
	[Name] varchar(20) not null,
	[Surname] varchar(20) not null,
	[Photo] varbinary(MAX),
	[Email] varchar(100) check(Email like '%@%.%'),
	[Phone] varchar(16) CHECK(
        [Phone] LIKE '+420[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR
        [Phone] LIKE '+420 [0-9][0-9][0-9] [0-9][0-9][0-9] [0-9][0-9][0-9]' OR
        [Phone] LIKE '[0-9][0-9][0-9] [0-9][0-9][0-9] [0-9][0-9][0-9]' OR
        [Phone] LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or [Phone] is null
    ) 
);

insert into Employee(Employee_Role_ID,[Name],[Surname], [Login], [Password])
-- password = 123
values(1,'Maksym','Kintor','admin', '6A2DAF302F70D5F0E24F699FA7F09F408514BE8186F49328BFFF36AEEDB2B5C1'),
(2,'Maksym','Kintor Pracovni','employee', '6A2DAF302F70D5F0E24F699FA7F09F408514BE8186F49328BFFF36AEEDB2B5C1');
/* Create a filtered index on the colum RFID_Tag */
CREATE UNIQUE INDEX IX_UsersRFIDTag_NotNull
    ON Employee(RFID_Tag) WHERE RFID_Tag IS NOT NULL;

go

/* Create a filtered index on the colum Email */
CREATE UNIQUE INDEX IX_UsersEmail_NotNull
    ON Employee(Email) WHERE Email IS NOT NULL;

go

/* Create a filtered index on the colum Phone */
CREATE UNIQUE INDEX IX_UsersPhone_NotNull
    ON Employee(Phone) WHERE Phone IS NOT NULL;


create table Attendance
(
	ID int primary key identity(1,1),
	Employee_ID int foreign key references Employee(ID) on delete cascade not null,
	Datetime_of_entry datetime not null,
	Type_of_entry bit
);

create table System_Message
(
	ID int primary key identity(1,1),
	Author_Employee_ID int foreign key references Employee(ID) on delete cascade not null,
	Title varchar(64) not null,
	Content varchar(600) not null,
	Date_of_delivery datetime not null
);

create table Have_Read
(
	ID int primary key identity(1,1),
	Employee_ID int foreign key references Employee(ID) on delete cascade not null,
	System_Message_ID int foreign key references System_Message(ID) not null,
	Is_Read bit default 0
);

go

create or alter trigger Message_trigger
on System_Message
after insert
as
begin try
	begin transaction;
	 declare @ID int

	 select @ID = i.ID from inserted i;

	 insert into Have_Read(Employee_ID, System_Message_ID)
	 select e.ID, @ID from Employee e;

	commit transaction;
end try
begin catch
	IF @@TRANCOUNT > 0
		ROLLBACK

	DECLARE @ErrorMessage NVARCHAR(4000), @ErrorSeverity INT;
	SELECT @ErrorMessage = ERROR_MESSAGE(),@ErrorSeverity = ERROR_SEVERITY();
	RAISERROR(@ErrorMessage, @ErrorSeverity, 1);
end catch;
go

commit transaction;

select Employee.ID, Employee.RFID_Tag, Employee_Role.Role_name, Employee.Login, Employee.Name, Employee.Surname, Employee.Photo, Employee.Email, Employee.Phone from Employee inner join Employee_Role on Employee.Employee_Role_ID = Employee_Role.ID where Login='admin'


insert into System_Message(Author_Employee_ID,Title, Content, Date_of_delivery)
values(1,'Message3','some lorem ipsum', CURRENT_TIMESTAMP());

insert into Employee(Employee_Role_ID,[Name],[Surname], [Login], [Password])
-- password = 123
values(2,'Employee','Number 3','employee3', '6A2DAF302F70D5F0E24F699FA7F09F408514BE8186F49328BFFF36AEEDB2B5C1');

select * from Have_Read;
select * from System_Message;

select mes.ID as 'Message_ID', hr.ID as 'Have_read_ID', hr.Is_Read, CONCAT(emp.Name,' ',emp.Surname) as 'Author_name', mes.Title, mes.Content, mes.Date_of_delivery
from Employee emp join System_Message mes on emp.ID = mes.Author_Employee_ID
join Have_Read hr on hr.System_Message_ID = mes.ID where hr.Employee_ID = 1;

update Have_Read
set Is_Read = 1
where ID = 12;

ALTER TABLE System_Message
ALTER COLUMN Date_of_delivery datetime;