﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_Hall.Data;
using Microsoft.EntityFrameworkCore;

namespace Event_Hall.Controllers
{
    public class EventsController : Controller
    {

        public IActionResult Index(string user="guest")
        {
            if (user == "Admin")
            {
                return View("Admin");
            }
            else if (user == "Presentor")
            {
                return View("Presentor");
            }
            else return View("Index");
        }
    }
}
