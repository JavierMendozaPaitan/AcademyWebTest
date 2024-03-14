use master
drop database if exists ACADEMY
Create database ACADEMY
go

use ACADEMY
drop table if exists Student
create table Student
(
	Id int Identity(1,1) NOT NULL,
	StudentName nvarchar(100) NULL,
	Email nvarchar(100) NULL,
	StudentLevelId int NULL,
	CreateDate date NULL,
	ModifiedDate date NULL
	CONSTRAINT pk_student_Id PRIMARY KEY(Id)
);
go
drop table if exists StudentLevel
create table StudentLevel
(
	Id int Identity(1,1) NOT NULL,
	LevelName nvarchar(50) NULL,
	Description nvarchar(100) NULL,
	CreateDate date NULL,
	ModifiedDate date NULL
	CONSTRAINT pk_StudentLevel_Id PRIMARY KEY(Id)
);
go
drop table if exists Course
create table Course
(
	Id int Identity(1,1) NOT NULL,
	CourseName nvarchar(100) NULL,
	Description nvarchar(100) NULL,
	TeacherId int NULL,
	StartDate date NULL,
	EndDate date NULL,
	CreateDate date NULL,
	ModifiedDate date NULL
	CONSTRAINT pk_Course_Id PRIMARY KEY(Id)
);
go
drop table if exists Teacher
create table Teacher
(
	Id int Identity(1,1) NOT NULL,
	TeacherName nvarchar(100) NULL,
	Email nvarchar(100) NULL,
	CreateDate date NULL,
	ModifiedDate date NULL
	CONSTRAINT pk_Teacher_Id PRIMARY KEY(Id)
);
go
drop table if exists StudentCourse
create table StudentCourse
(
	Id int Identity(1,1) NOT NULL,
	StudentId int NOT NULL,
	CourseId int NOT NULL,
	CreateDate date NULL,
	ModifiedDate date NULL
	CONSTRAINT pk_StudentCourse_Id PRIMARY KEY(Id)
);
go

insert into StudentLevel
values('Initial', 'Starting level', GETDATE(), GETDATE())
insert into StudentLevel
values('Training', 'Training level', GETDATE(), GETDATE())
insert into StudentLevel
values('Junior', 'Initial professional experience level', GETDATE(), GETDATE())
insert into StudentLevel
values('Senior', 'Advanced professional experience level', GETDATE(), GETDATE())

insert into Teacher
values('John Simpson', 'john@email.com', GETDATE(), GETDATE())
insert into Teacher
values('Abby Wallmart', 'abby@email.com', GETDATE(), GETDATE())
insert into Teacher
values('Phineas Webb', 'phineas@email.com', GETDATE(), GETDATE())
insert into Teacher
values('Walter Smith', 'walter@email.com', GETDATE(), GETDATE())
insert into Teacher
values('Agatha Holmes', 'agatha@email.com', GETDATE(), GETDATE())

insert into Course
values('Math', 'Mathematics for the impacient', 2, '2024-04-12', '2024-06-15', GETDATE(), GETDATE())
insert into Course
values('Technology', 'Technology for the impacient', 2, '2024-04-12', '2024-06-15', GETDATE(), GETDATE())
insert into Course
values('Physics', 'Physics for the impacient', 1, '2024-04-12', '2024-06-15', GETDATE(), GETDATE())
insert into Course
values('Econonmy', 'Economy for the impacient', 5, '2024-04-12', '2024-06-15', GETDATE(), GETDATE())
insert into Course
values('Science', 'Science for the impacient', 3, '2024-04-12', '2024-06-15', GETDATE(), GETDATE())

insert into Student
values ('Javier Mendoza', 'javier@email.com', 1, GETDATE(), GETDATE())
insert into Student
values ('John Kaplan', 'john@email.com', 2, GETDATE(), GETDATE())
insert into Student
values ('Pierre Sandler', 'pierre@email.com', 3, GETDATE(), GETDATE())
insert into Student
values ('Gavin James', 'gavin@email.com', 3, GETDATE(), GETDATE())
insert into Student
values ('Amanda Thompson', 'amanda@email.com', 5, GETDATE(), GETDATE())
insert into Student
values ('Silvia Huertas', 'silvia@email.com', 5, GETDATE(), GETDATE())

insert into StudentCourse
values (1, 3, GETDATE(), GETDATE())
insert into StudentCourse
values (1, 4, GETDATE(), GETDATE())
insert into StudentCourse
values (1, 5, GETDATE(), GETDATE())
insert into StudentCourse
values (2, 3, GETDATE(), GETDATE())
insert into StudentCourse
values (2, 5, GETDATE(), GETDATE())
insert into StudentCourse
values (3, 1, GETDATE(), GETDATE())
insert into StudentCourse
values (3, 2, GETDATE(), GETDATE())
insert into StudentCourse
values (3, 3, GETDATE(), GETDATE())
insert into StudentCourse
values (4, 4, GETDATE(), GETDATE())
insert into StudentCourse
values (4, 5, GETDATE(), GETDATE())
insert into StudentCourse
values (5, 2, GETDATE(), GETDATE())
insert into StudentCourse
values (5, 5, GETDATE(), GETDATE())