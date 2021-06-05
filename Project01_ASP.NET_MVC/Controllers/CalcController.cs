using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01_ASP.NET_MVC.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Sum(int x, int y)
        {
            var res = x + y;
            ViewData["res"] = res;

            return View();
        }
        public ActionResult Sub(int x, int y)
        {
            var res = x - y;
            ViewData["res"] = res;

            return View();
        }
        public ActionResult Mul(int x, int y)
        {
            var res = x * y;
            ViewData["res"] = res;

            return View();
        }
        public ActionResult Div(int x, int y)
        {
            if(y != 0)
            {
                var res = x / y;
                ViewData["res"] = res;
            }
            else
            {
                ViewData["res"] = "ERROR";

            }

            return View();
        }


    }
}
