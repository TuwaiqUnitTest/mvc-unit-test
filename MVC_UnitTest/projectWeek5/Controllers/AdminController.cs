using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projectWeek5.Models;

namespace projectWeek5.Controllers
{
    public class AdminController : Controller
    {
        List<AdminModel> admins = new List<AdminModel>()

            {
                new AdminModel(){admin_Id=1,admin_Name="Shahad",admin_PhonNumber=0503664482,
                 admin_Email="shahad1_cs@hotmail.com",admin_Password="qazzaqQ1@4"},
         
                new AdminModel(){admin_Id=2,admin_Name="Ali",admin_PhonNumber=0553388292,
                admin_Email="ali9603@gmail.com",admin_Password="Qazzaq@12"}
             };
             public IActionResult Index(int ? Id)
            {
            AdminModel admin = admins.Find(admins => admins.admin_Id == Id);
            if(admin == null)
            {
                return Content("Not found admin");
            }

            ViewData["admin"] = admin;
            return View("Index");

            }
    }
}
