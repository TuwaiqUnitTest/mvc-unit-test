using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project01_ASP.NET_MVC.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string image { get; set; }
        public Author author{ get; set; }

      

    }
}
