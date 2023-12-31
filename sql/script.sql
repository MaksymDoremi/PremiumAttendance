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
	[Photo] varbinary(MAX) null default null,
	[Email] varchar(40) null DEFAULT null,
	[Phone] varchar(30) null DEFAULT null
);

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
	Date_of_delivery date not null
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