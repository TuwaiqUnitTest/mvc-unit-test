using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caulculations.Controllers
{
    public class CaulculationController : Controller
    {
        // GET: Calculation
        public ActionResult Index()
        {
            return View();
        }

        public int Addition(int num1, int num2)
        {

            return num1 + num2;
        }

        public int Subtraction(int num1, int num2)
        {

            return num1 - num2;
        }

        public int Multiplication(int num1, int num2)
        {

            return num1 * num2;
        }


        public int Division(int num1, int num2)
        {

            return num1 / num2;
        }




    }
}