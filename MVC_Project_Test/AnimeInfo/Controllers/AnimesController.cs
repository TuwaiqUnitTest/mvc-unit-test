using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using AnimeInfo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace AnimeInfo.Controllers
{

    public class AnimesController : Controller
    {
      public static string HttpRequest()
        {

            using (var client = new HttpClient())
            {
                var uri = new Uri("https://api.jikan.moe/v3/top/anime/1/upcoming");

                var response = client.GetAsync(uri);

                response.Wait();

                var result = response.Result.Content.ReadAsStringAsync();
                Console.WriteLine(result);
                return result.Result;

            }

           

        }

        List<Top> AnimeList = new List<Top>();
        Anime anime = JsonConvert.DeserializeObject<Anime>(HttpRequest());
        public IActionResult Index()
        {
            
            
             for (int i = 0; i < 17; i++)
             {
                 AnimeList.Add(new Top() {mal_id= anime.Top[i].mal_id , title = anime.Top[i].title , score=anime.Top[i].score ,
                                         image_url= anime.Top[i].image_url , rank= anime.Top[i].rank , episodes= anime.Top[i].episodes ,
                                         url= anime.Top[i].url , start_date= anime.Top[i].start_date , type= anime.Top[i].type
                 });
             }
            
            ViewData["AnimeList"] = AnimeList;
            return View("Animes");
        }

        
    }
}
