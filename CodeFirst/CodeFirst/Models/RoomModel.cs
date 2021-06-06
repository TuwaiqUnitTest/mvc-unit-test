using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class RoomModel
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string RoomType { get; set; }
        [MaxLength(4)]
        public int RoomNumber { get; set; }
        [Required]
        public bool Empty { get; set; }


        // Navigation Properties:
        public int StudentID { get; set; } //FK
        public Student Student { get; set; }

        // public ICollection<Student> Students { get; set; } => Ahmed's suggestion
    }
}
