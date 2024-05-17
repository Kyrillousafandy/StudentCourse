using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourse.Entities
{
    internal class StudentsCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }
        // navigation properity => one 
        //public student student { get; set; }
        //public Course course { get; set; }
    }
}
