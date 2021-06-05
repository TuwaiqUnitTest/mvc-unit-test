using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeInfo.Models;

namespace AnimeInfo.Controllers
{
    public class AboutwebsiteController : Controller
    {
        public IActionResult Index()
        {
            AboutwebsiteModel aboutwebsite = new AboutwebsiteModel();
            var title = aboutwebsite.title = "Anime Info";
            var text = aboutwebsite.text = "This is a simple websites that gives a list of the top upcoming animes";

            ViewData["title"] = title;
            ViewData["text"] = text;

            return View("Aboutwebsite");
        }

        
    }
}
