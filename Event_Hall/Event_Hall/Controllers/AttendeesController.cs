using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_Hall.Data;

namespace Event_Hall.Controllers
{
    public class AttendeesController : Controller
    {
        private readonly AppDbContext _db;

        public AttendeesController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var DbAttendees = _db.Attendees.ToList();
            ViewBag.Attendees = DbAttendees;
            return View();
        }
    }
}
