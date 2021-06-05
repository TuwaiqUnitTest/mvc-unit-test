using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeInfo.Models;

namespace AnimeInfo.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ContactModel contact = new ContactModel();
            var title = contact.title = "Contact Info";
            var text = contact.text = "You can find my contact information below";
            var phoneNumber = contact.phoneNumber = "+966 55 555 5555";
            var github = contact.github = "https://github.com/pivot85";
            var email = contact.email = "saud.alshammari@tuwaiq.edu.sa";
            ViewData["title"] = title;
            ViewData["text"] = text;
            ViewData["phonenumber"] = phoneNumber;
            ViewData["github"] = github;
            ViewData["email"] = email;

            return View("Contact");
        }
    }
}
