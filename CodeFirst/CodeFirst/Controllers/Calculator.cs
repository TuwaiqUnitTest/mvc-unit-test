using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Controllers
{
    public class Calculator : Controller
    {
        public int sum(int a,int b)
        {
            return a + b;
        }

        public int div(int a,int b)
        {
            if (b != 0)
                return a / b;
            else return 0;
        }

        public int mul(int a,int b)
        {
            return a * b;
        }

        public int sub(int a,int b)
        {
            return a - b;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
