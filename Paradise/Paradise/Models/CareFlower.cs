using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paradise.Models
{
    public class CareFlower
    {
        public int ID { get; set; }
        public string LevelCare { get; set; }
        public string Place { get; set; }
        public string Size { get; set; }

        //Navigations proprties
        public int FlowerId { get; set; } //FK
        public Flower Flower { get; set; }

    }
}
