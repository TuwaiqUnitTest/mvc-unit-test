using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Major { get; set; }
        public int Grade { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
