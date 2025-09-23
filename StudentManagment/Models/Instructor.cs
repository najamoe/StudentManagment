namespace StudentManagment.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public DateTime HireDate { get; set; }

        // Navigation property for related courses
        public ICollection<Courses> Courses { get; set; } = new List<Courses>();
    }
}
