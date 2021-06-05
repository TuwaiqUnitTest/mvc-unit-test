using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using Blog_Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Website.Controllers
{
    public class RealDataArticlesController : Controller
    {
        public Root getaListfromAPI(string url)
        {
            var client = new HttpClient();
            var RequestUri = new Uri(url);
            var response = client.GetAsync(RequestUri);
            response.Wait();
            var result = response.Result.Content.ReadAsStringAsync();
            Root v = JsonSerializer.Deserialize<Root>(result.Result);
            return v;
        }

       

        const string BASE_URL = "https://newsapi.org/v2/everything?domains=wsj.com&apiKey=69c46e9199ab4eb98c7dc9780908574b";

       
        public  IActionResult Index()
        {
            Console.WriteLine("Hi");
            Console.WriteLine(getaListfromAPI(BASE_URL).articles[2].title);
            ViewData["Articles"] = getaListfromAPI(BASE_URL).articles;
            return View();
        }

        public IActionResult Details(int? id)
        {


            ViewData["Articles"] = getaListfromAPI(BASE_URL).articles;
               
                ViewData["id"] = id;


                return View();
            
        }
    }
}
