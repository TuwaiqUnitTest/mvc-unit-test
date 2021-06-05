using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_DB.Data;
using MVC_DB.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_DB.Controllers
{
    public class StudnetsController : Controller
    {
        private readonly AppDbContext _db;

        public StudnetsController(AppDbContext context)
        {
            _db = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var Studnets = _db.Studnets.ToList();
            var StudentId = _db.Studnets.FirstOrDefault(a => a.ID == 1)?.firstName;
            //var StudentId = _db.Studnets.SingleOrDefault(a => a.ID == 6)?.firstName;
            var greaterThanTwo = _db.Studnets.Where(a => a.ID > 2).ToList();
            ViewData["StudentId"] = StudentId;
            ViewData["greaterThanTwo"] = greaterThanTwo;
            ViewData["Studnets"] = Studnets;
            return View();
        }

        public IActionResult Search(string txt)
        {
            var searchItem = _db.Studnets.Where(a => a.firstName.Contains(txt) || a.email.Contains(txt)).ToList();
            ViewData["searchItem"] = searchItem;
            return View("Index");
        }

        public IActionResult Details(int id)
        {
            var stdDetails = _db.Studnets.Where(a => a.ID == id).ToList();
            if (stdDetails == null)
                throw new ArgumentNullException(nameof(stdDetails));

            else
                ViewData["stdDetails"] = stdDetails;

            return View();
        }

        //Test data Insartion
        public IList<StudnetModel> Excute()
        {
            return _db.Studnets.ToList();
        }
    }
}
