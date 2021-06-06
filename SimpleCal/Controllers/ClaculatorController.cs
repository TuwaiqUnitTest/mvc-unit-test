using System;
using Microsoft.AspNetCore.Mvc;

namespace SimpleCal.Controllers
{
    public class ClaculatorController : Controller
    {
        
        int result;
        public int  sum(int firstNumber, int secondNumber)
        {
            return result = 1 + 5;

        }
        public int  sub(int firstNumber, int secondNumber)
        {
            return result = 2 - 4;

        }
        public int Mul(int firstNumber, int secondNumber)
        {
            return result = 3 * 3;
        }

    }
}
