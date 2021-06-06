using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCClcu.Controllers
{
    public class CalculationController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // here
        //Addition
        public int Add(int NUM1, int NUM2)
        {
            return NUM1 + NUM2;
        }
        
        //Division
        public int Div(int NUM1, int NUM2)
        {
            if (NUM2 == 0)
                throw new DivideByZeroException("You Can't divide the numbers by zero.");
            else
                return NUM1 / NUM2;
        }
        //Subtraction
        public int Subtract(int NUM1, int NUM2)
        {
            return NUM1 - NUM2;
        }
        //Multiplication
        public int Mul(int NUM1, int NUM2)
        {
            return NUM1 * NUM2;
        }
        //DoubleNumber
        public int DoubleNumber(int NUM)
        {
            return NUM * NUM;
        }
        
    }
}