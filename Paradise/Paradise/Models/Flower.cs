using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Paradise.Models
{
    public class Flower
    {
        public int ID { get; set; }
        [Required]
        public string Image { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        public string Tempreture { get; set; }

        //Navigations proprties
        public CareFlower CareFlower { get; set; }

        public List<Comment> Comments { get; set; }

    }
}
