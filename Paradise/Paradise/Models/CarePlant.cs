using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paradise.Models
{
    public class CarePlant
    {
        public int ID { get; set; }
        public string LevelCare { get; set; }
        public string Place { get; set; }
        public string Size { get; set; }

        //Navigations proprties
        public int PlantId { get; set; } //FK
        public Plant Plant { get; set; }
    }
}
