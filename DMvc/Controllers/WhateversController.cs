using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMvc.Controllers
{
    public class WhateversController : Controller
    {

        public double squareRoot(double x)
        {
           
            if(x <0)
            {
                throw new Exception("The number must not be NEGATIVE");
            }
            double sqrt = Math.Sqrt(x);
            Console.WriteLine("the square root is " + sqrt); 
           
            return sqrt ;          
        }
        public double div(double x, double y)
        {
            if (y == 0)
            {
                throw new Exception("The input should NOT equal ZERO");
            }
            double res = x / y; ;

            Console.WriteLine("the result of the division is " + res);

            return res;
        }
        public float sum(float x, float y)
        {
            return (x + y);
        }
    }
}
