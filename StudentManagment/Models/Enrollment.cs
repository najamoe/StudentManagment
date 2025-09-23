using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagment.Models;

namespace StudentManagment.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string? Grade { get; set; }

        // Navigation properties
        public required Students Student { get; set; }
        public required Courses Course { get; set; }
    }
}
