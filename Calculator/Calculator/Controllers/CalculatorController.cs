using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public int Sum(int x, int y) => (x + y);
        public int Sub(int x, int y) => (x - y);
        public int Div(int x, int y) => y == 0 ? throw new DivideByZeroException("Cannot divide by zero") : (x / y);

    }
}
