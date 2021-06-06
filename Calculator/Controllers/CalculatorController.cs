using System;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        public float Addition(float x, float y)
        {
            return x + y;
        }

        public float Subtraction(float x, float y)
        {
            return x - y;
        }

        public float Multiplication(float x, float y)
        {
            return x * y;
        }
        public float Division(float x, float y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }
    }
}