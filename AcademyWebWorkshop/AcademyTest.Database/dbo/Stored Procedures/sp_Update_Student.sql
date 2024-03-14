
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