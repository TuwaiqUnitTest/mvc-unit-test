using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pets.Models
{
    public class PetsInfoModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string seller { get; set; }
        public int phoneNo { get; set; }
        public string location { get; set; }
        public string image { get; set; }
    }
}
