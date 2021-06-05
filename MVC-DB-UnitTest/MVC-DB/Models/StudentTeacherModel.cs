using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_DB.Models
{
    public class StudentTeacherModel
    {
        //
        public int Id { get; set; }
        
        //
        public StudnetModel Studnet { get; set; }
        public int StudnetID { get; set; }

        //
        public TeacherModel Teacher { get; set; }
        public int TeacherID { get; set; }
    }
}
