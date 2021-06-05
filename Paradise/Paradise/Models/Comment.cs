using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Paradise.Models
{
    public class Comment
    {
        public int ID { get; set; }
        [Required]
        public string Message { get; set; }

        public Flower Flower { get; set; }

        //FK
        public int FlowerId { get; set; }
        public Plant Plant { get; set; }

        //FK
        public int PlantId { get; set; }
    }
}
