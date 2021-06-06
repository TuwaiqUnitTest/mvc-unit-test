using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: /<controller>/
        public string ConcatString(string str1 ,string str2)
        {
            if (str1 == null || str2 == null)
                return null;


            
            return str1+ str2;
        }

        public int sum(int FirstNumber, int SecondNumber)
        {
            
            return FirstNumber + SecondNumber;
        }

        public int subtraction(int FirstNumber, int SecondNumber)
        {

            return FirstNumber - SecondNumber;
        }
    }
}
