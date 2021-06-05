using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Paradise.Data;
namespace Paradise.Models
{
    public class Plant
    {
        
        public int ID { get; set; }
        public string Image { get; set; }

        public string Name { get; set; }
        public string Tempreture { get; set; }

        //Navigations proprties
        public CarePlant CarePlant { get; set; }

        public List<Comment> Comments { get; set; }


    }
}
