using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Models
{
    public class Courses
    {
        public int CourseId { get; set; }
        public required string Title { get; set; }

        [Precision(5, 2)]
        public decimal Credits { get; set; }

        // Foreign key property - Created with nullable to allow courses without an assigned instructor
        public int? InstructorId { get; set; }

        // Navigation property for related enrollments
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public Instructor? Instructor { get; set; }
    }
}
