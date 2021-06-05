using System;
using System.Collections.Generic;
namespace MVC_DB.Models
{
    public class TeacherModel
    {
        public int ID { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }

        //
        public List<Subject> subjects { get; set; }
    }
}
