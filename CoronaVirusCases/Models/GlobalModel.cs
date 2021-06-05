using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaVirusCases.Models
{
    public class GlobalModel
    {
        public int TotalConfirmed { get; set; }
        public int NewConfirmed { get; set; }
        public int TotalRecovered { get; set; }
        public int NewRecovered { get; set; }
        public int TotalDeaths { get; set; }
        public int NewDeaths { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
