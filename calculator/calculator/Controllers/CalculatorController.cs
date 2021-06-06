using System;
using System.Threading;
using Microsoft.AspNetCore.Mvc;

namespace calculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET
        public float Multiplication(float a , float b)
        {
            return a * b ;
        }

        public float Div(float a, float b)
        {
            if (b == 0)
            {
                throw new Exception();
            }

            return a / b; 
        }

        public float Addition(float a, float b)
        {
            return a + b; 
        }
    }
}