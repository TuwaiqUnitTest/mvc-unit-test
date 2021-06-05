using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using animeik.Models;
using Microsoft.AspNetCore.Mvc;

namespace animeik.Controllers
{
    public class AnimeController : Controller
    {
        // GET
        public IActionResult Index(int id)
        {
            Utilities.animelist.Clear();
            JsonObj list = getaListfromAPI("https://jikan1.p.rapidapi.com/top/anime/1/tv");
            foreach (var anime in list.top)
            {
                Utilities.animelist.Add(new Anime(anime.mal_id, anime.title, anime.url, anime.image_url, anime.type,
                    anime.episodes, anime.start_date, anime.end_date, anime.score));
            }

            ViewData["user"] = false;
            ViewData["list"] = Utilities.animelist;

            //userfaviort anime 
            if (id != 0)
            {
                ViewData["user"] = true;
                ViewData["list"] = FindUser(id).Fav;
            }

            return View("Index");
        }

        public IActionResult Details(int id)
        {
            ViewData["anime"] = Utilities.animelist.Find(a => a.id == id);
            return View();
        }

        public IActionResult Search(string animeName)
        {
            Utilities.animelist.Clear();
            var list = getaListfromAPI("https://jikan1.p.rapidapi.com/search/anime?q=" + animeName);
            foreach (var anime in list.results)
            {
                Utilities.animelist.Add(new Anime(anime.mal_id, anime.title, anime.url, anime.image_url, anime.type,
                    anime.episodes, anime.start_date, anime.end_date, anime.score));
            }

            ViewData["list"] = Utilities.animelist;
            return View("Index");
        }


        public JsonObj getaListfromAPI(string url)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "f628437b3cmsh2fa811b8eb8b3dep14e7d2jsnd1d1125259c8");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "jikan1.p.rapidapi.com");
            var RequestUri = new Uri(url);
            var response = client.GetAsync(RequestUri);
            response.Wait();
            var result = response.Result.Content.ReadAsStringAsync();
            JsonObj v = JsonSerializer.Deserialize<JsonObj>(result.Result);
            return v;
        }

        public User FindUser(int id)
        {
            User user = Utilities.users.Find(i => i.id == id);

            if (user == null)
            {
                throw new NullReferenceException();
            }
            return user;
        }
    }
}