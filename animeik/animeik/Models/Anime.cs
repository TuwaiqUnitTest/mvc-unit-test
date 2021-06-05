namespace animeik.Models
{
    public class Anime
    {
        public int id;
        public string title;
        public string url;
        public string image_url;
        public string type;
        public int? episodes;
        public string start_date;
        public string end_date;
        public double score;

        public Anime(int id,string title, string url, string imageUrl, string type, int? episodes, string startDate, string endDate, double score)
        {
            this.id = id;
            this.title = title;
            this.url = url;
            image_url = imageUrl;
            this.type = type;
            this.episodes = episodes;
            start_date = startDate;
            this.score = score;
            this.end_date = endDate;
        }
    }
}