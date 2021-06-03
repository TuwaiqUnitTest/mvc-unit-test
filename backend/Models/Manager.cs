using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Manager
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
