using Microsoft.AspNetCore.Mvc;
using Project01_ASP.NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01_ASP.NET_MVC.Controllers
{
    public class AuthorsController : Controller
    {

        private List<Author> authors = new List<Author>()
            {
                new Author(){Id = 1 , FullName = "Michael" , Email = "Michael@example.com" , Phone = "645-123-4353"},
                new Author(){Id = 2 , FullName = "William" , Email = "William@example.com" , Phone = "234-123-4353"},
                new Author(){Id = 3 , FullName = "Paul" , Email = "Paul@example.com" , Phone = "123-123-4353"},
                new Author(){Id = 4 , FullName = "Tyler" , Email = "Tyler@example.com" , Phone = "543-123-4353"},
                new Author(){Id = 5 , FullName = "Jake" , Email = "Jake@example.com" , Phone = "766-123-4353"},
                new Author(){Id = 6 , FullName = "John" , Email = "John@example.com" , Phone = "878-123-4353"},
                new Author(){Id = 7 , FullName = "Kevin" , Email = "Kevin@example.com" , Phone = "567-123-4353"},
            };


        public IActionResult Index()
        {
            ViewData["allAuthors"] = authors;
            return View("Index");
        }

        public IActionResult Detail(int id = 1)
        {
            
            ViewData["author"] = authors.Find(aut => aut.Id == id);


            if (ViewData["author"] == null)
            {
                return View("fof");
            }


            return View("Detail");
        }


    }
}
