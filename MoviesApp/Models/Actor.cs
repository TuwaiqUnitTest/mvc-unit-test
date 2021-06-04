using System.Text.Json.Serialization;

namespace MoviesApp.Models
{
    public class Actor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CastID { get; set; }
        [JsonIgnore]
        public Cast Cast { get; set; }
    }
}