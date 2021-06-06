using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Math.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public int sum(int number1, int number2) {

            int result = number1 + number2;
            return result;
        }

        public int Sub(int number1, int number2)
        {

            int result = number1 - number2;
            return result;
        }

        public int Multi(int number1, int number2)
        {

            int result = number1 * number2;
            return result;
        }
    }
}
