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
    internal class StudentConfiguration : IEntityTypeConfiguration<student>
    {
        public void Configure(EntityTypeBuilder<student> builder)
        {
            builder.HasMany(S => S.StudentCourses)
                .WithOne(/*SC => SC.student*/);
        }
    }
}
