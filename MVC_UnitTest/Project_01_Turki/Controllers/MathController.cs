using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project_01_Turki.Controllers
{
    public class MathController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }

        public int GBToMB(int gb)
        {
            return gb * 1024;
        }

        public int MBToGB(int mb)
        {
            return mb / 1024;
        }
    }
}
