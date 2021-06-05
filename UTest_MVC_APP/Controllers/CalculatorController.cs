using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UTest_MVC_APP.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();
        }

        public int divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Denominator can not be zero");
            return a / b;
        }
        public int multiply(int a, int b)
        {
            return a * b;
        }


    }
}
