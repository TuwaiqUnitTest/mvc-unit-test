using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int Add(int param1, int param2)
        {
            return param1 + param2;
        }
        public int Sub(int param1, int param2)
        {
            return param1 - param2;
        }
        public int Mul(int param1, int param2)
        {
            return param1 * param2;
        }
        public int Div(int param1, int param2)
        {
            if (param2 == 0)
                throw new DivideByZeroException("Can't divide by zero, Otherwise you will got infinity");
            else
                return param1 / param2;
        }
    }
}


