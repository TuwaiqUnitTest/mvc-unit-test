using System.Collections.Generic;
using EzzRestaurant.Models;
using Microsoft.AspNetCore.Mvc;

namespace EzzRestaurant.Controllers
{
    public class ProductsController : Controller
    {
        private List<ProductModel> _products = new List<ProductModel>
        {
            new ProductModel(){Id = 1 ,CategoryId = 1, Name = "Steak" ,  Price = 100.00 , img = "https://images.pexels.com/photos/3535395/pexels-photo-3535395.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"},
            new ProductModel(){Id = 2 ,CategoryId = 1, Name = "Pizza" , Price = 16.00 , img = "https://images.pexels.com/photos/825661/pexels-photo-825661.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"}, 
            new ProductModel(){Id = 3 ,CategoryId = 1, Name = "spaghetti" , Price = 42.00 , img = "https://images.pexels.com/photos/41320/beef-cheese-cuisine-delicious-41320.jpeg?auto=compress&cs=tinysrgb&dpr=2&w=500"},
            new ProductModel(){Id = 4 ,CategoryId = 1, Name = "pasta" , Price = 34.00 , img = "https://images.pexels.com/photos/2703468/pexels-photo-2703468.jpeg?auto=compress&cs=tinysrgb&dpr=2&w=500"},
            new ProductModel(){Id = 5 ,CategoryId = 2, Name = "Orange" , Price = 14.00 , img = "https://images.pexels.com/photos/1002778/pexels-photo-1002778.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"},
            new ProductModel(){Id = 6 ,CategoryId = 2, Name = "Mango" , Price = 14.00 , img = "https://images.pexels.com/photos/4023132/pexels-photo-4023132.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"},
            new ProductModel(){Id = 7 ,CategoryId = 3, Name = "Entrees one" , Price = 21.00 , img = "https://images.pexels.com/photos/4669304/pexels-photo-4669304.jpeg?auto=compress&cs=tinysrgb&dpr=2&w=500"},
            new ProductModel(){Id = 7 ,CategoryId = 4, Name = "Flafel" , Price = 21.00 , img = "https://images.pexels.com/photos/6275118/pexels-photo-6275118.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"},
            
        };
        // GET
        public IActionResult Index()
        {
            ViewData["Products"] = _products;
            return View("Index");
        }
    }
}