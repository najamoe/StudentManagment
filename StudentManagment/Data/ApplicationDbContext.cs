using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


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

    }
}
