using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class InstructorStudent
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public int InstructorId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
    }
}
