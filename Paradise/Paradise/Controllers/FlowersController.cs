using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Paradise.Data;

namespace Paradise.Controllers
{
    public class FlowersController : Controller
    {
        private readonly AppDbContext _db;

        public FlowersController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {

            var Flowers = _db.Flowers.ToList();
            ViewData["Flowers"] = Flowers;
            return View();
        }

        public IActionResult Details(int? id)
        {
           var CareFlower  = _db.CareFlower.ToList().Find(a => a.FlowerId == id);
           var Flower = _db.Flowers.ToList().Find(a => a.ID == id);

            ViewData["CareFlower"] = CareFlower;
            ViewData["Flower"] = Flower;


            return View();
            }

        }
    }

