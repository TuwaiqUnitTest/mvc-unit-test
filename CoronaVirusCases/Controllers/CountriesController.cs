using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CoronaVirusCases.Models;

namespace CoronaVirusCases.Controllers
{
    public class CountriesController : Controller
    {

        public IActionResult Index()
        {
            if(ListOfCases.GlobalCases == null)
            {
                Random r = new Random();

                ListOfCases.GlobalCases = new GlobalModel
                {
                    TotalConfirmed = r.Next(500000000, 1000000000),
                    NewConfirmed = r.Next(10000, 70000),
                    TotalRecovered = r.Next(1000000, 500000000),
                    NewRecovered = r.Next(10000, 70000),
                    TotalDeaths = r.Next(1000000, 500000000),
                    NewDeaths = r.Next(10000, 70000),
                    CreatedAt = new DateTime()
                };

            }

            ViewData["GlobalCases"] = ListOfCases.GlobalCases;
            return View();
        }

        public IActionResult Global()
        {
            return View();
        }
    }
}
