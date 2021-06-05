using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pets.Controllers
{
    public class SwapController : Controller
    {
        public IActionResult swap(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            
            return View();
        }
    }
}
