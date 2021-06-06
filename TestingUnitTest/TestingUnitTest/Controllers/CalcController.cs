using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingUnitTest.Controllers
{
    public class CalcController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public int sub(int num1,int num2)
        {

            return num1-num2;
        }
       

        public int sum(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}
