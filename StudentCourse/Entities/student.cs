using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourse.Entities
{
    internal class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public ICollection<StudentsCourse> StudentCourses { get; set; } = new HashSet<StudentsCourse>();
    }
}
