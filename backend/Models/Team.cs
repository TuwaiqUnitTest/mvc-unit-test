using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int InstructorId { get; set; }
        [Required]
        public DateTime FormDate { get; set; }
    }
}
