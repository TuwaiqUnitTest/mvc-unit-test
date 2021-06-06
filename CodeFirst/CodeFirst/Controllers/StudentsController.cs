using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Data;
using CodeFirst.Models;

namespace CodeFirst.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _db;

        public StudentsController(AppDbContext context)
        {
            _db = context; // all contexts in the database will go inside _db
        }

        

        public IActionResult stringMaker(string str)
        {
            str = "Hello";
            return View(str);
        }
        // GET - /Students
        // GET: /<controller>/
        public IActionResult stringMaker()
        {

            var Students1 = _db.Students.FirstOrDefault(a => a.Id == 1).LastName; //? thorw an exception, its like if not null bring the value..

            var a = _db.Students.SingleOrDefault(a => a.Id == 1).FirstName;

            var greaterthan2 = _db.Students.Where(a => a.Id > 1).ToList();

            ViewBag.Students1 = Students1;
            ViewBag.a = a;
            ViewData["Greaterthan2"] = greaterthan2;

            var Students = _db.Students.ToList(); // Because it will return Students entity as a collection, we used ToList() to convert it to List


            ViewData["Students"] = Students;
            return View();
        }

        public IActionResult Search(string SearchForName)
        {
            var Students = _db.Students.Where(s=>s.FirstName.Contains(SearchForName)|| s.LastName.Contains(SearchForName)).ToList();
            ViewData["Search"] = Students;
            return View();
        }
        public IActionResult Details(int? id)
        {
            var Students = _db.Students.Where(a => a.Id == id).ToList();
            ViewData["Details"] = Students;
            return View();
        }


    }
}
