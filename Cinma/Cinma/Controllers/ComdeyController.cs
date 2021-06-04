using Cinma.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinma.Controllers
{
    public class ComdeyController : Controller
    {
        List<ComedyMovieModel> comdeyLis = new List<ComedyMovieModel>()
        {
            new ComedyMovieModel(){Id=1, Title="Hababam Sinifi", Director="Ertem Egilmez", Rating =9.3, Img ="https://i.ytimg.com/vi/hf2-8MRPGu8/maxresdefault.jpg" },
            new ComedyMovieModel(){Id=2, Title="Parasite", Director="Bong Joon Ho", Rating= 8.6, Img ="https://m.media-amazon.com/images/M/MV5BYWZjMjk3ZTItODQ2ZC00NTY5LWE0ZDYtZTI3MjcwN2Q5NTVkXkEyXkFqcGdeQXVyODk4OTc3MTY@._V1_UY1200_CR90,0,630,1200_AL_.jpg" },
            new ComedyMovieModel(){Id=3, Title="Life Is Beautiful", Director="Roberto Benigni ", Rating = 8.6, Img = "https://2.bp.blogspot.com/-wgdLlnI2jYk/VhoZ1gVwbtI/AAAAAAAAM_w/6IgFJOR6MzU/s1600/Life%2BIs%2BBeautiful.jpg" },
            new ComedyMovieModel(){Id=4, Title="The Intouchables", Director="Olivier Nakache, Éric Toledano", Rating = 8.5, Img="https://m.media-amazon.com/images/M/MV5BMTYxNDA3MDQwNl5BMl5BanBnXkFtZTcwNTU4Mzc1Nw@@._V1_UX67_CR0,0,67,98_AL_.jpg" },
            new ComedyMovieModel(){Id=5, Title="Back to the Future", Director="Robert Zemeckis", Rating = 8.5, Img ="https://m.media-amazon.com/images/M/MV5BZmU0M2Y1OGUtZjIxNi00ZjBkLTg1MjgtOWIyNThiZWIwYjRiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY1200_CR71,0,630,1200_AL_.jpg" }
        };


        public IActionResult Index()
        {
            ViewData["comdeyLis"] = comdeyLis;
            return View("Index");
        }
    }
}
