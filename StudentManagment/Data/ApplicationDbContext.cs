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
        }
    }
}
