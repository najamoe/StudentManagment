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
        public int Credits { get; set; }
    }
}
