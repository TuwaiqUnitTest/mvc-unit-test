using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Principle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Rating { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
