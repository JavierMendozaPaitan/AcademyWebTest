using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public string? Description { get; set; }
        public int TeacherId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set;}
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get;set; }
    }
}
