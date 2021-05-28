using System.Text.Json.Serialization;

namespace MoviesApp.Models
{
    public class Review
    {
        public int ID { get; set; }
        [JsonIgnore]
        public Movie movie { get; set; }
        public int MovieID { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
    }
}