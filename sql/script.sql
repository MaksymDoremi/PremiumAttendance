use PremiumAttendance

go

begin transaction;

create table Position
(
	ID int primary key identity(1,1),
	Position_name varchar(20) not null unique
)

insert into Position(Position_name)
values('Administrator'),('Employee')

create table Employee
(
	ID int primary key identity(1,1),
	Position_ID int foreign key references Position(ID) not null,
	RFID_tag varchar(10) default null,
	[Login] varchar(30) unique not null,
	[Password] varchar(64) not null,
	[Name] varchar(30) not null,
	[Surname] varchar(30) not null,
	[Photo] varbinary(MAX) null default null,
	[Email] varchar(40) null DEFAULT null,
	[Phone] varchar(30) null DEFAULT null
)

CREATE UNIQUE INDEX IX_UsersRFIDTag_NotNull
    ON Employee(RFID_Tag) WHERE RFID_Tag IS NOT NULL;

CREATE UNIQUE INDEX IX_UsersEmail_NotNull
    ON Employee(Email) WHERE Email IS NOT NULL;

CREATE UNIQUE INDEX IX_UsersPhone_NotNull
    ON Employee(Phone) WHERE Phone IS NOT NULL;

create table Attendance
(
	ID int primary key identity(1,1) not null,
	Employee_ID int foreign key references Employee(ID) not null,
	Date_time datetime not null,
	Check_in bit not null -- Check in = True, Check out = False
);


commit transaction;