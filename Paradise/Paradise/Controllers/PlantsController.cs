using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Paradise.Data;

namespace Paradise.Controllers
{
  
    public class PlantsController : Controller
    {
        private readonly AppDbContext _db;

        public PlantsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Plants = _db.Plants.ToList();
            ViewData["Plants"] = Plants;
            return View();
        }

        public IActionResult Details(int? id)
        {
            var CarePlant = _db.CarePlant.ToList().Find(a => a.PlantId == id);
            var Plants = _db.Plants.ToList().Find(a => a.ID == id);

            ViewData["CarePlant"] = CarePlant;
            ViewData["Plants"] = Plants;


            return View();
        }
    }
}
