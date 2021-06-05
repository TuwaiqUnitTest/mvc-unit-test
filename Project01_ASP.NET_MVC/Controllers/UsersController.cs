using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Models;

namespace Books.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index(int? id = 1)
        {
            List<UserModel> Users = new List<UserModel>()
            {
                new UserModel {Id=1,Name="أمل",Email="Amal@example.com",PhoneNumber="050000000"},
                new UserModel {Id=2,Name="لمى",Email="Lama@example.com",PhoneNumber="050000001"},
                new UserModel {Id=3,Name="نوره",Email="Nora@example.com",PhoneNumber="050000002"},
                new UserModel {Id=4,Name="بدر",Email="Bader@example.com",PhoneNumber="050000003"},
                new UserModel {Id=5,Name="فهد",Email="Fahad@example.com",PhoneNumber="050000004"},
                new UserModel {Id=6,Name="سلطان",Email="sultan@example.com",PhoneNumber="050000005"},
            };

            UserModel User = Users.Find(p => p.Id == id);
            if (Users == null)
            {
                return Content("Not found");
            }
            else
            {
                ViewData["User"] = User;
                return View();
            }
        
        }
    }
}
