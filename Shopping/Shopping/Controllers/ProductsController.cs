using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shopping.Models;

namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        List<ProductModel> productModels = new List<ProductModel>(){
            new ProductModel() {Id = 1,Name="Iphone 12 Pro",Price=1200.3f, Image = "https://creativecenter.bg/uploads//products/235/3506d54c9404706e0e1f57508045e500.jpeg"},
            new ProductModel() { Id = 2, Name = "Iphone 8", Price = 720.0f, Image = "https://i.ebayimg.com/images/g/pGUAAOSwsAdd0txg/s-l640.jpg" },
            new ProductModel() { Id = 3, Name = "samsung 2000", Price = 900.1f, Image = "https://cdn.alloallo.media/catalog/product/samsung/galaxy-s/galaxy-s10/galaxy-s10-prism-black.jpg" },
            new ProductModel() { Id = 4, Name = "I phone S10", Price = 8001.5f, Image = "https://m.xcite.com/media/catalog/product/cache/3/image/9df78eab33525d08d6e5fb8d27136e95/p/r/primary_white__1_2.jpg" }
    };

        // Note: this method has been factored out from Index() controller,
        // for testing purposes.
        public List<ProductModel> AllProducts()
        {
            return productModels;
        }

        // GET: /<controller>/
        public IActionResult Index(string color)
        {
            ViewData["AllProducts"] = AllProducts();
            ViewData["givenColor"] = color;

            return View();
        }




        // Note: this method has been factored out from Details() Action,
        // for the test purposes.
        public ProductModel QueriedProduct(int id) {
            ProductModel Product = productModels.Find(p => p.Id == id);
            if (Product == null)
            {
                throw new NullReferenceException(" 404: The product you're looking for is not available at the moment");
            }
            else
            {
                return Product;
            }
        }

        // GET - /products/deatils/id
        public IActionResult Details(int id) {
                ViewData["Product"] = QueriedProduct(id);
                return View();
        }


        public void AddProduct(int id, string name, float price, string image) {
          if (productModels.Any(product => product.Id == id))
          {
              throw new Exception(" 404: The product you're trying to add has already existed");
          }
          else
          {
                productModels.Add(new ProductModel() { Id = id, Name = name, Price = price, Image = image });
          }

        }


        public void RemoveProduct(int id) {
          ProductModel Product = productModels.Find(p => p.Id == id);
          if (Product == null)
          {
              throw new NullReferenceException(" 404: The product you're trying to delete is not exist");
          }
          else
          {
                productModels.Remove(Product);

          }
        }
    }
}
