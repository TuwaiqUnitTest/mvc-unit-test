using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        float result;
        public float Sum(float FirstNum, float SecondNum)
        {
            return result = 4 + 6;
        }
        public float Sub(float FirstNum, float SecondNum)
        {
            return result = 6 - 3;
        }
        public float Mul(float FirstNum, float SecondNum)
        {
            return result = 2 * 3;
        }
    }
}
