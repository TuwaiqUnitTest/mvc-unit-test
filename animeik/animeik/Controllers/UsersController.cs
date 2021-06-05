using System;
using System.Collections.Generic;
using animeik.Models;
using Microsoft.AspNetCore.Mvc;

namespace animeik.Controllers
{
    public class UsersController : Controller
    {
        // GET

        public IActionResult Index()
        {
            ViewData["users"] = Utilities.users;
            return View();
        }

        public void addFav(int id, int animeId)
        {
            Anime a = Utilities.animelist.Find(i => i.id == animeId);
            if (a == null)
            {
                throw new NullReferenceException();
            }
            Utilities.users.Find(u => u.id == id).addToFav(a);
        }
        public IActionResult removeFav(int id, int animeId)
        {
            Utilities.users.Find(u => u.id == id).removeFav(animeId);
            return View("index");
        }
    }
}