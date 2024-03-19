using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider.Models;

namespace DataProvider.Abstractions
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
