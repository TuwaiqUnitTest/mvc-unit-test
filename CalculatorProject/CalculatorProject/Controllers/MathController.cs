using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public int SumNumber(int num1, int num2)
        {
            return num1 + num2;

        }
        public int SubNumber(int num1, int num2)
        {
            return num1 - num2;

        }
        public int DivideNumber(int num1, int num2)
        {
            return num1 / num2;

        }
    }
}


