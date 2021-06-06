using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int Mul(int firts, int second)
        {
            return firts * second;
        }
        public int Div(int firts, int second)
        {
            return firts / second;
        }

    }
}
