using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Paradise.Data;


namespace Paradise.Controllers
{
    public class CommunityController : Controller
    {
        public IActionResult Index(string type="")
        {
            if (type == "admin") return View("Admin");
            else if (type == "user") return View("User");
            else return View("Index");
        }
    }
}
