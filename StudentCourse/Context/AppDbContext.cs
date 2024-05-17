using Microsoft.EntityFrameworkCore;
using StudentCourse.Configuration;
using StudentCourse.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourse.Context
{
    internal class AppDbContext:DbContext
    {

        #region OnConfiguring and connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseSqlServer("Server = .; Database = StudentCourseKyrillos; Trusted_Connection = True;TrustServerCertificate=True");
        #endregion


        #region OnModelCreating /Fluent Api ApplyConfiguration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration<student>(new StudentConfiguration());
            modelBuilder.ApplyConfiguration<Course>(new CourseConfiguration());
            modelBuilder.ApplyConfiguration<StudentsCourse>(new studentCourseConfiguration());


            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Dbsets
        public DbSet<student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        #endregion
    }
}
