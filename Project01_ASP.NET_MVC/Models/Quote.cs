using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01_ASP.NET_MVC.Models
{
    public class Quote
    {
        public Quotes[] Property1 { get; set; }
    }

    public class Quotes
    {
        public string text { get; set; }
        public string author { get; set; }
    }

}
