using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Speciality { get; set; }
        public int Rating { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public int BootcampId { get; set; }
    }
}
