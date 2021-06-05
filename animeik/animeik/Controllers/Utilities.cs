using System.Collections.Generic;
using animeik.Models;

namespace animeik.Controllers
{
    public class Utilities
    {
        public static List<Anime> animelist = new List<Anime>()
        {
            new Anime(1,"one piece", "https://myanimelist.net/anime/47778/Kimetsu_no_Yaiba__Yuukaku-hen",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9),
            new Anime(2,"naruto", "url",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9),
            new Anime(3,"attack on titan", "url",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9),
            new Anime(4,"this is title", "url",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9),
            new Anime(5,"this is  of the first anime ", "url",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9),
            new Anime(6,"this is title", "url",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9),
            new Anime(7,"this is  of the first anime ", "url",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9),
            new Anime(8,"this is title", "url",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9)
        };
        public static List<User> users = new List<User>()
        {
            new User(1, "hassan"),
            new User(2, "sara")
        };
    }
}