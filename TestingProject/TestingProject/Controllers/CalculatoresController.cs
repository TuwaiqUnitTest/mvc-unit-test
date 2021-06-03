using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingProject.Controllers
{
    public class CalculatoresController : Controller
    {
        public IActionResult Index()
        {
            return View("Home");
        }

        public int SalaryWithdraw(int salary, int amount)
        {
            if (amount<=salary) return salary - amount;
            else throw new Exception("funds are less than amount");
        }   

    }
}
