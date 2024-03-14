create procedure sp_Delete_Student
(
	@Id int
)
as
begin
	delete from Student 
	where Id = @Id
end