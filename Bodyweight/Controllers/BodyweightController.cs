using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bodyweight.Controllers
{
    public class BodyweightController : Controller
    {
        public IActionResult Index()
        {
            return View("Home");
        }

    
        public double perfect_Body_Wieght(double height , String Gender)
        {
            switch (Gender)
            {
                case "male":
                    return (height - 100) - ((height - 150) / 4);
                case "femaile":
                    return (height - 100) - ((height - 150) / 2);
                default:
                    return 0;
            }
           
        }
    }
}
