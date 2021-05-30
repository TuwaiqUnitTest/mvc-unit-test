using ECommerce_ASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_ASPNET.Controllers
{
    public class ProductsController : Controller
    {
        public static List<CategoryModel> Categories()
        {
            return new List<CategoryModel>()
            {
                new CategoryModel() {Id=1, Title="Electronics" }
            };
        }

        public static List<ProductModel> Products()
        {
            var categories = Categories();

            return new List<ProductModel>()
            {
                new ProductModel() {Id=1, Title="iPhone", Description="iPhone 13", Price=5000, Image="https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/iphone-12-pro-blue-hero?wid=940&hei=1112&fmt=png-alpha&.v=1604021661000", Category=categories[0] }

                , new ProductModel() { Id=2, Title="PlayStation 5", Description="The new playstation", Price=2443, Image="https://www.tokyogames.com/1659-large_default/sony-playstation-5-digital-edition-console.jpg", Category=categories[0]}

                , new ProductModel() {Id=3, Title="Laptop HP", Description="Laptop HP ProBook", Price=3000, Image="https://i1.wp.com/roiya.net/wp-content/uploads/2020/06/3-2.png?fit=1659%2C1246&ssl=1", Category=categories[0]}
            };
        }

        public IActionResult Index()
        {
            ViewData["Products"] = Products();
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewData["Product"] = Products().FirstOrDefault(p => p.Id == id);

            if (ViewData["Product"] == null) return NotFound();

            return View();
        }

        public IActionResult CreateForm()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
