using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Student_Teacher
    {
        public int id { get; set; }
        public Student Student { get; set; }
        public int student_id { get; set; }
        public Teacher Teacher { get; set; }
        public int teacher_id { get; set; }
    }
}
