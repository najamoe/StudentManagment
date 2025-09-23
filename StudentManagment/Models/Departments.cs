using Microsoft.Identity.Client;

namespace StudentManagment.Models
{
    public class Departments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int budget { get; set; }
        public DateOnly StartDate { get; set; }

        // Foreign key to instructor who is the department head
        public int? DepartmentHead { get; set; }

        //Navigation property
        public Instructor? Instructor { get; set; }
    }
}
