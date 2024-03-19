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
    public class CourseRepository : ICourseRepository
    {
        private readonly string connectionString = @"Data Source=EPESMALW042D;Initial Catalog=ACADEMY;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        public IEnumerable<Course> GetCourses()
        {
            List<Course> courses = new();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetAll_Courses", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var course = new Course
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        CourseName = Convert.ToString(reader["CourseName"]),
                        Description = Convert.ToString(reader["Description"]),
                        TeacherId = Convert.ToInt32(reader["TeacherId"]),
                        StartDate = Convert.ToDateTime(reader["StartDate"]),
                        EndDate = Convert.ToDateTime(reader["EndDate"]),
                        CreateDate = Convert.ToDateTime(reader["CreateDate"]),
                        LastModifiedDate = Convert.ToDateTime(reader["ModifiedDate"])
                    };
                    courses.Add(course);
                }
            }

            return (courses);
        }
    }
}
