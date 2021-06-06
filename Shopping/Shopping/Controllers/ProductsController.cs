using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Models;
using System.Web;

namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        public List<ProductModel> Product = new()
        {
            new ProductModel() { Id = 1, Name = "Super pax", Price = 12312.34f , Image = "https://www.cbc.ca/kids/images/superpix_thumbnail.jpg" },
            new ProductModel() { Id = 2, Name = "Minecraft", Price = 12312.34f , Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSfKCBHtqSMwdfgtKwrnXoz00NyfRe2OMr4eRqfvKpHVeSm2i3BzO6hb3Ff9NGgNs5UyQQ&usqp=CAU" },
            new ProductModel() { Id = 3, Name = "Shovel knight dig", Price = 12312.34f, Image = "https://www.nitrome.com/styles/images/jsrotator/shovel-knight-dig.png" },
            new ProductModel() { Id = 4, Name = "GTA 5", Price = 12312.34f, Image="https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1581607644-61s8HfeFoL.jpg?crop=0.998xw:1xh;center,top&resize=480:*" },
            new ProductModel() { Id = 5, Name = "Crash bandicote", Price = 12312.34f , Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTh6L-M8cFGZvk---omof54tEiuFcaBVhCv2w&usqp=CAU"},
            new ProductModel() { Id = 6, Name = "Ratchet clank", Price = 12312.34f, Image = "https://insomniac.games/wp-content/uploads/2020/10/RCRA_RiftApart_Keyart_1080x1080.jpg" }
            };
        private ProductModel addProduct = new ProductModel() { Id = 7, Name = "Star wars", Price = 12312.34f, Image= "https://media.contentapi.ea.com/content/dam/gin/images/2019/04/star-wars-jedi-home-hero-large-xl.jpg.adapt.crop1x1.767p.jpg" };
        public IActionResult Index(string color)
        {
            ViewData["products"] = Product;
            return View();
        }
        public IActionResult Details(int id =7)
        {
            
            ViewData["oneProduct"] = addProduct;
            ViewData["products"] = Product.Find(match: model => model.Id == id);

            return View();
        }
        public IActionResult Random(int id = 1)
        {
            ProductModel foundProd;
            foreach(var p in Product)
            {
                if (p.Id == id)
                {
                    foundProd = p;
                    ViewData["foundProduct"] = foundProd;
                }
                /*else return Content("404 Page");*/
            }
            return View();
        }
        public IActionResult Check(int? id )
        {
            ProductModel product = Product.Find(match: model => model.Id == id);

            if (product == null){
                return Content("No product with that name");
            }
            else
            {
                ViewData["products"] = product;
                return View();
            }
        }
        public IActionResult stringChanger(string name ="")
        {
            string show = name;
            ViewData["show string"] = show;
                return View();
            
        }
    }
}
