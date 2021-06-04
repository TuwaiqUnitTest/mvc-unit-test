using Cinma.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinma.Controllers
{
    public class DramaController : Controller
    {
         List<DramaMovieModel> dramaList = new List<DramaMovieModel>()
        {
            new DramaMovieModel(){Id=1, Title="The Godfather", Director="Francis Ford Coppola", Rating =9.0, Img ="https://upload.wikimedia.org/wikipedia/ar/thumb/3/3c/%D9%85%D9%84%D8%B5%D9%82_%D9%81%D9%84%D9%85_%D8%A7%D9%84%D8%B9%D8%B1%D8%A7%D8%A8_%28%D8%A7%D9%84%D8%AC%D8%B2%D8%A1_%D8%A7%D9%84%D8%A3%D9%88%D9%84%29%281972%29.jpg/260px-%D9%85%D9%84%D8%B5%D9%82_%D9%81%D9%84%D9%85_%D8%A7%D9%84%D8%B9%D8%B1%D8%A7%D8%A8_%28%D8%A7%D9%84%D8%AC%D8%B2%D8%A1_%D8%A7%D9%84%D8%A3%D9%88%D9%84%29%281972%29.jpg" },
            new DramaMovieModel(){Id=2, Title="The Dark Knight", Director=" Bong Joon Ho", Rating= 9.0, Img ="https://upload.wikimedia.org/wikipedia/ar/thumb/4/48/%D9%85%D9%84%D8%B5%D9%82_%D9%81%D9%84%D9%85_%D9%81%D8%A7%D8%B1%D8%B3_%D8%A7%D9%84%D8%B8%D9%84%D8%A7%D9%85_%282008%29.jpg/260px-%D9%85%D9%84%D8%B5%D9%82_%D9%81%D9%84%D9%85_%D9%81%D8%A7%D8%B1%D8%B3_%D8%A7%D9%84%D8%B8%D9%84%D8%A7%D9%85_%282008%29.jpg" },
            new DramaMovieModel(){Id=3, Title="The Godfather: Part II", Director="Francis Ford Coppola", Rating = 9.0, Img = "https://media.elcinema.com/uploads/_315x420_3bf49fd4d5ce272c59abce3cb1c269990406ddd240c0666ed60b046842e8f038.jpg" },
            new DramaMovieModel(){Id=4, Title="The Lord of the Rings: The Return of the King", Director=" Peter Jackson", Rating = 8.8, Img="https://upload.wikimedia.org/wikipedia/ar/0/0b/LOTR_The_Fellowship_of_the_Ring.jpg" },
            new DramaMovieModel(){Id=5, Title="Forrest Gump", Director="Robert Zemeckis", Rating = 8.8, Img ="https://media.elcinema.com/uploads/_315x420_c01abfa7651e0370a6b697cd576a87f0d86f015de5e98a0d75c41b9877a1ca5d.jpg" }
        };
        public IActionResult Index()
        {
            return View(dramaList);
        }
        public IActionResult Details(int? id)
        {
            if (id < 0)
            {
                // return Content("لا يوجد منتج بهذا الايدي");
                return RedirectToAction("Index", "Errors");
            }
            else
            {
                DramaMovieModel DM = dramaList.Find(b => b.Id == id);

                ViewData["DramaMovie"] = DM;
                return View("Details");
            }

        }


    }
}
