using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaVirusCases.Controllers
{
    public class RegionsController : Controller
    {
        public IActionResult Index(string? country)
        {
            if (country != "SA")
            {
                return Content("country not available");
            }

            return View("Index");
        }

    }
}
