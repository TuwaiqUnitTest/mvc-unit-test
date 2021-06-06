using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using plantsShop.Models;
namespace plantsShop.Controllers
{
    public class ImagesController : Controller
    {
        private List<ImageModel> images = new List<ImageModel>()
        {
            new ImageModel {image = "https://images.unsplash.com/photo-1548247416-ec66f4900b2e?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=726&q=80"},
            new ImageModel {image = "https://images.unsplash.com/photo-1526336024174-e58f5cdd8e13?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=668&q=80"},
            new ImageModel {image = "https://images.unsplash.com/photo-1561948955-570b270e7c36?ixid=MnwxMjA3fDB8MHxzZWFyY2h8NXx8Y2F0fGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"},
            new ImageModel {image = "https://images.unsplash.com/photo-1574158622682-e40e69881006?ixid=MnwxMjA3fDB8MHxzZWFyY2h8N3x8Y2F0fGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"},
            new ImageModel {image = "https://images.unsplash.com/photo-1543852786-1cf6624b9987?ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8Y2F0fGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"},
            new ImageModel {image = "https://images.unsplash.com/photo-1529778873920-4da4926a72c2?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTB8fGNhdHxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"},
            new ImageModel {image = "https://images.unsplash.com/photo-1494256997604-768d1f608cac?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fGNhdHxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"},
            new ImageModel {image = "https://images.unsplash.com/photo-1533743983669-94fa5c4338ec?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTJ8fGNhdHxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"},
            new ImageModel {image = "https://images.unsplash.com/photo-1598188306155-25e400eb5078?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTd8fGNhdHxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"},
            new ImageModel {image = "https://images.unsplash.com/photo-1415369629372-26f2fe60c467?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTl8fGNhdHxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"},
            new ImageModel {image = "https://images.unsplash.com/photo-1511275539165-cc46b1ee89bf?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjB8fGNhdHxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"},
            new ImageModel {image = "https://images.unsplash.com/photo-1569591159212-b02ea8a9f239?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjN8fGNhdHxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"},
            new ImageModel {image = "https://images.unsplash.com/photo-1517331156700-3c241d2b4d83?ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mjh8fGNhdHxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"},
            new ImageModel {image = "https://images.unsplash.com/photo-1518288774672-b94e808873ff?ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mjl8fGNhdHxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"},
            new ImageModel {image = "https://images.unsplash.com/photo-1513360371669-4adf3dd7dff8?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MzB8fGNhdHxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"},
            new ImageModel {image = "https://images.unsplash.com/photo-1568152950566-c1bf43f4ab28?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MzR8fGNhdHxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"},
            new ImageModel {image = "https://images.unsplash.com/photo-1571566882372-1598d88abd90?ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mzl8fGNhdHxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60"},
        };
        public IActionResult Index()
        {
            ViewData["Images"] = images;
            return View();
        }
    }
}
