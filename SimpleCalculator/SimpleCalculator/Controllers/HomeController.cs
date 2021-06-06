using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleCalculator.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalculator.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {            
        }

        int[] myNum = { 10, 20, 30, 40 };

        public IActionResult Index()
        {
            ViewData["Welcome"] = "Welcome to the simple calculator!!";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Min()
        {
            int min = myNum.Min();
            ViewData["Min"] = min;
            return View();
        }

        public IActionResult Max()
        {
            int max = myNum.Max();
            ViewData["Max"] = max;
            return View();
        }


        public IActionResult Sum()
        {
            int sum = myNum.Sum();
            ViewData["Sum"] = sum;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
