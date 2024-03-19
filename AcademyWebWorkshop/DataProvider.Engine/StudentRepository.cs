using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider.Abstractions;
using DataProvider.Models;
using Microsoft.Data.SqlClient;

namespace DataProvider.Engine
{
    public class StudentRepository : IStudentRepository
    {
        private readonly string connectionString = @"Data Source=EPESMALW042D;Initial Catalog=ACADEMY;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        public void DeleteStudent(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand("sp_Delete_Student", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Student> GetStudents()
        {
            List<Student> students = new();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetAll_Student", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var student = new Student
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        StudentName = Convert.ToString(reader["StudentName"]),
                        Email = Convert.ToString(reader["Email"]),
                        StudentLevelId = Convert.ToInt32(reader["StudentLevelId"]),
                        CreateDate = Convert.ToDateTime(reader["CreateDate"]),
                        LastModifiedDate = Convert.ToDateTime(reader["ModifiedDate"])
                    };
                    students.Add(student);
                }
            }

            return (students);
        }

        public void InsertStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand("sp_Add_Student", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                cmd.Parameters.AddWithValue("@StudentName", student.StudentName);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@StudentLevelId", student.StudentLevelId);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand("sp_Update_Student", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                cmd.Parameters.AddWithValue("@Id", student.Id);
                cmd.Parameters.AddWithValue("@StudentName", student.StudentName);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@StudentLevelId", student.StudentLevelId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
