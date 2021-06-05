using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CodeFirst.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomType { get; set; }
        [Required]
        public bool Empty { get; set; }

        public Student Student { get; set; }
        public int StudentId { get; set; }
        
    }
}
