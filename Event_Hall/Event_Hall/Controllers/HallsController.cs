using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_Hall.Data;

namespace Event_Hall.Controllers
{
    public class HallsController : Controller
    {
        private readonly AppDbContext _db;

        public HallsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var DbHalls = _db.Halls.ToList();
            ViewBag.Halls = DbHalls;
            return View();
        }
    }
}
