use ACADEMY
go
	drop procedure if exists sp_Add_Student
go
create procedure sp_Add_Student
(
	@StudentName nvarchar(100),
	@Email nvarchar(100),
	@StudentLevelId int
)
as
begin
	insert into Student(StudentName, Email, StudentLevelId, CreateDate, ModifiedDate)
	values (@StudentName, @Email, @StudentLevelId, GETDATE(), GETDATE())
end

go
	drop procedure if exists sp_Delete_Student
go
create procedure sp_Delete_Student
(
	@Id int
)
as
begin
	delete from Student 
	where Id = @Id
end
go
	drop procedure if exists sp_GetAll_Student
go
create procedure sp_GetAll_Student
as
begin
	select * from Student
end
go
	drop procedure if exists sp_Update_Student
go

create procedure sp_Update_Student
(
	@Id int,
	@StudentName nvarchar(100),
	@Email nvarchar(100),
	@StudentLevelId int
)
as
begin
	update Student
	set StudentName = @StudentName,
		StudentLevelId = @StudentLevelId,
		Email = @Email,
		ModifiedDate = GETDATE()
	where Id = @Id
end
go
	drop procedure if exists sp_GetAll_Teacher
go
create procedure sp_GetAll_Teacher
as
begin
	select * from Teacher
end
go
	drop procedure if exists sp_GetAll_StudentLevel
go
create procedure sp_GetAll_StudentLevel
as
begin
	select * from StudentLevel
end
go