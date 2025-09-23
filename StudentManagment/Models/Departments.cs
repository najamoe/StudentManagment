using Microsoft.Identity.Client;

namespace StudentManagment.Models
{
    public class Departments
    {
        public int DepartmentId { get; set; }
        public required string Name { get; set; }
        public int budget { get; set; }
        public DateOnly StartDate { get; set; }

        // Foreign key to instructor who is the department head
        public int? DepartmentHeadId { get; set; }

        //Navigation property
        public Instructor? DepartmentHead { get; set; }
    }
}
