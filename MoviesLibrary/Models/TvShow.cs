namespace MoviesLibrary.Models
{
    public class TvShow
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Summary { get; set; }
        public int Rating { get; set; }
        public string Poster { get; set; }
        
        // Navigations properties
        public FavoriteTvShow FavoriteTvShow { get; set; }
    }
}