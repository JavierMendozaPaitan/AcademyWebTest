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