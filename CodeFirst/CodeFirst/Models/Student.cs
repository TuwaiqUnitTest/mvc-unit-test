using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // Navigation Properties:
        public RoomModel Room { get; set; }
        // public int RoomId { get; set; } => Ahmed's suggestion

        // Navigation Property:
        public List<Student_Teacher> student_teacher { get; set; }
    }
}
