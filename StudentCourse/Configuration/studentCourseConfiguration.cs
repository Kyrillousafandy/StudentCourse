








using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentCourse.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourse.Configuration
{
    internal class studentCourseConfiguration : IEntityTypeConfiguration<StudentsCourse>
    {
        public void Configure(EntityTypeBuilder<StudentsCourse> builder)
        {
            builder.HasKey(SC => new { SC.StudentId, SC.CourseId });
        }
    }

    
}