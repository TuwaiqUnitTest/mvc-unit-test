using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Models;

namespace Pets.Controllers
{
    public class AdminController : Controller
    {
        private List<AdminModel> admins = new List<AdminModel>()
            {
                new AdminModel () {email="taghreed@gmail.com",password=112233},
                new AdminModel () {email="battal@gmail.com",password=112233}
            };
        // /admin/edit?email=taghreed@gmail.com&password=112233
        public IActionResult Edit(string email, int password)
        {
            AdminModel _user = admins.Find(b => b.email == email);
            if (_user != null && password == 112233)
            {
                PetsController p = new PetsController();
                ViewData["PetsInfo"] = p.PetsInfo;
                return View("PetsInfo");
            }
            else
            {
                return RedirectToAction("SignIn");
            }
        }
        public IActionResult SignIn()
        {
            return View();
        }
        
    }
}
