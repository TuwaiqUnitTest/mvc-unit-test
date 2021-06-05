using System;
namespace MVC_DB.Models
{
    public class Subject
    {
        public int ID { get; set; }
        public string Title { get; set; }

        //one to many
        public TeacherModel Teacher { get; set; }
        public int SubjectId { get; set; }
    }
}
