using System.Collections.Generic;

namespace MoviesApp.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CoverURL { get; set; }
        public int Rating { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}