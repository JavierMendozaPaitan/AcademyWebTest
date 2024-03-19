using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? StudentName { get; set; }
        public string? Email { get; set; }
        public int StudentLevelId { get; set; }
        public DateTime? CreateDate{ get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
