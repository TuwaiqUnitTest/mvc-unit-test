using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MoviesApp.Models
{
    public class Cast
    {
        public int ID { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public int MovieID { get; set; }
        [JsonIgnore]
        public Movie Movie { get; set; }
    }
}