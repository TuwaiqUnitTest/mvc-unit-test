using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public int Sum(int a, int b) => (a + b);


        public int Division(int a, int b) => b == 0 ? throw new DivideByZeroException("Dividing by zero equals null :(") : (a / b);

        public int Subtraction(int a, int b) => (a - b);

    }
}
