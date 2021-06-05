using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class CalculatorController : Controller
    {
        public ActionResult Sum(int x, int y)
        {
            var result = x + y;
            ViewData["result"] = result;

            return View();
        }
        public ActionResult Sub(int x, int y)
        {
            var result = x - y;
            ViewData["result"] = result;

            return View();
        }
        public ActionResult Mul(int x, int y)
        {
            var result = x * y;
            ViewData["result"] = result;

            return View();
        }
        public ActionResult Div(int x, int y)
        {
            var result = x / y;
            ViewData["result"] = result;

            return View();
        }
    }
}