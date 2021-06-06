using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using plantsShop.Models;

namespace plantsShop.Controllers
{
    public class ShopsController : Controller
    {
        private List<ShopModel> shops = new List<ShopModel>()
        {
            new ShopModel{name="vetStreet",location="123 32nd street",phone=303378170},
            new ShopModel{name="Allvet",location="505 baseline street",phone=599300245},
            new ShopModel{name="CatRescue",location="buffalo canyon street",phone=011923499},
            new ShopModel{name="HiCat",location="downtown street",phone=578579304},
            new ShopModel{name="vetClinic",location="707 broadway street",phone=777339992},
        };
        public IActionResult Index()
        {
            ViewData["Shops"] = shops;
            return View("Index");
        }
    }
}
