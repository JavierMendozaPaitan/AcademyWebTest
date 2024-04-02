using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademyWeb.Abstractions;
using AcademyWeb.Models;
using DataProvider.Abstractions;
using DataProvider.Models;

namespace AcademyWeb.Engine
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(
            IStudentRepository studentRepository) 
        {
            _studentRepository = studentRepository;
        }

        public void AddStudent(StudentAcademy student)
        {
            var studentRepository = new Student 
            {
                StudentName = student.Name,
                Email = student.Email,
                StudentLevelId = Convert.ToInt32(student.StudentLevel)                
            };
            _studentRepository.InsertStudent(studentRepository);
        }

        public List<StudentAcademy> GetStudents()
        {
            var students = new List<StudentAcademy>();
            students = _studentRepository.GetStudents().Select(x => new StudentAcademy
            {
                Id = x.Id,
                Email = x.Email,
                Name = x.StudentName,
                StudentLevel = x.StudentLevelId.ToString()
            }).ToList();

            return students;
        }

        public List<StudentAcademy> GetStudentsInTraining()
        {
            var students = new List<StudentAcademy>();
            var list = _studentRepository.GetStudents().Where(x => x.StudentLevelId == 2);
            foreach (var item in list)
            {
                var student = new StudentAcademy
                {
                    Id = item.Id,
                    Name = item.StudentName,
                    Email = item.Email,
                    StudentLevel = "Training"
                };
                students.Add(student);
            }

            return students;
        }

        public void RemoveStudent(int id)
        {
            _studentRepository.DeleteStudent(id);
        }
    }
}
