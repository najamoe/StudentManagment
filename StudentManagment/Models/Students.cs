using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Models
{
    public class Students
    {
        public int StudentId { get; set; }
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public required string Email { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Navigation property for related enrollments
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    }
}
