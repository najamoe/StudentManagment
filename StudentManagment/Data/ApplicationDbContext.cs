using Microsoft.EntityFrameworkCore;
using StudentManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StudentManagment.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Models.Students> Students { get; set; }
        public DbSet<Models.Courses> Courses { get; set; }
        public DbSet<Models.Enrollment> Enrollments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>().HasKey(s => s.StudentId);
            modelBuilder.Entity<Courses>().HasKey(c => c.CourseId);  
            modelBuilder.Entity<Enrollment>().HasKey(e => e.EnrollmentId);
            modelBuilder.Entity<Instructor>().HasKey(i => i.InstructorId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
           modelBuilder.Entity<Courses>()
                .HasOne(c => c.Instructor)
                .WithMany(i => i.Courses)
                .HasForeignKey(c => c.InstructorId)
                .OnDelete(DeleteBehavior.SetNull);
        }


    }
}
