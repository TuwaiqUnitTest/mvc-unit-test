using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectUnitTest.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public float Div(float a,float b)
        {
            if (b ==0)
            {
                throw new DivideByZeroException("you are dividing by zero");
            }
            return (a/b);
        }

        public float Sum(float a, float b)
        {
            
            return (a + b);
        }

        public float Mult(float a, float b)
        {

            return (a * b);
        }

    }
}
