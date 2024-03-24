using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademyWeb.Models;

namespace AcademyWeb.Abstractions
{
    public interface IStudentService
    {
        List<StudentAcademy> GetStudentsInTraining();
        List<StudentAcademy> GetStudents();
        void AddStudent(StudentAcademy student);
    }
}
