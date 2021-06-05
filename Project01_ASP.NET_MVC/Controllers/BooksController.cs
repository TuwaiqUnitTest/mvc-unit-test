using Microsoft.AspNetCore.Mvc;
using Project01_ASP.NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01_ASP.NET_MVC.Controllers
{
    public class BooksController : Controller
    {
        private static List<Author> authors = new List<Author>()
            {
                new Author(){Id = 1 , FullName = "Michael" , Email = "Michael@example.com" , Phone = "645-123-4353"},
                new Author(){Id = 2 , FullName = "William" , Email = "William@example.com" , Phone = "234-123-4353"},
                new Author(){Id = 3 , FullName = "Paul" , Email = "Paul@example.com" , Phone = "123-123-4353"},
                new Author(){Id = 4 , FullName = "Tyler" , Email = "Tyler@example.com" , Phone = "543-123-4353"},
                new Author(){Id = 5 , FullName = "Jake" , Email = "Jake@example.com" , Phone = "766-123-4353"},
                new Author(){Id = 6 , FullName = "John" , Email = "John@example.com" , Phone = "878-123-4353"},
                new Author(){Id = 7 , FullName = "Kevin" , Email = "Kevin@example.com" , Phone = "567-123-4353"},
            };
        private List<Book> books = new List<Book>()
            {
                new Book(){Id = 1 , name = "XV6 Operating System" , author = authors[1], price = 75, image ="https://lh3.googleusercontent.com/proxy/YHyqn9zi1XW4jqqGPoYvDyjDuxMiMiuYxmXVS4zPUeqeXtUPtOQCox5qFHmDVHvyiy3MJTfaO93KMdoqFL116viiVWODPjnI9lwGfWNbmM9jeWiKeuk"},
                new Book(){Id = 2 , name = "Clean Code" , author = authors[3], price = 20, image ="https://images-na.ssl-images-amazon.com/images/I/41yafGMO+rL._SX258_BO1,204,203,200_.jpg"},
                new Book(){Id = 3 , name = "Intro to Algorithms" , author = authors[4], price = 35, image ="https://images-na.ssl-images-amazon.com/images/I/41T0iBxY8FL._SX440_BO1,204,203,200_.jpg"},
                new Book(){Id = 4 , name = "Refactoring" , author = authors[1], price = 25, image ="https://images-na.ssl-images-amazon.com/images/I/41trAWIzKAL._SX401_BO1,204,203,200_.jpg"},
                new Book(){Id = 5 , name = "Haskell" , author = authors[1], price = 80, image ="https://m.media-amazon.com/images/I/51Tm5TDpThL.jpg"},
                new Book(){Id = 6 , name = "Go Language" , author = authors[6], price = 35, image ="https://images-na.ssl-images-amazon.com/images/I/510Qib-dSCL.jpg"},
                new Book(){Id = 7 , name = "Python ML" , author = authors[2], price = 25, image ="https://images-na.ssl-images-amazon.com/images/I/41VkICdTF5L.jpg"},
                new Book(){Id = 8 , name = "JAVA" , author = authors[0], price = 50, image ="https://images-na.ssl-images-amazon.com/images/I/51EZ4Mzhz5L.jpg"},
                new Book(){Id = 8 , name = "using openMP" , author = authors[2], price = 35, image ="https://images-na.ssl-images-amazon.com/images/I/51O3HRtQVVL.jpg"},
                new Book(){Id = 9 , name = "Raspberry Pi" , author = authors[5], price = 25, image ="https://images-na.ssl-images-amazon.com/images/I/41ICEKEY5eL.jpg"},
                new Book(){Id = 11 , name = "C++20 Recipes" , author = authors[4], price = 30, image ="https://m.media-amazon.com/images/I/41MZo+Qib7L.jpg"},
            };



        public IActionResult Index()
        {
            ViewData["allBooks"] = books;

            return View("Index");
        }

        public IActionResult Detail(int id = 1)
        {
            ViewData["book"] = books.Find(b => b.Id == id);

            if (ViewData["book"] == null)
            {
                //return Content("not found");
                return View("fof");
            }

            return View("Detail");
        }




    }
}
