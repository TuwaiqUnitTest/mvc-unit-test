
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Models;

namespace Shopping.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> CustomerList = new List<Customer>()
        {
            new Customer {Customer_Id = 1 , Customer_Name="Fatma Alqhtnay",Customer_Email ="Fatma.qhtany@hotmail.com",Customer_Password="123sssSS"},
            new Customer {Customer_Id = 2 , Customer_Name="Houssh Alqhtnay",Customer_Email ="Houssh.qhtany@hotmail.com",Customer_Password="H234213"},
            new Customer {Customer_Id = 3 , Customer_Name="Abdulaziz Alqhtnay",Customer_Email ="Abdulaziz.qhtany@hotmail.com",Customer_Password="JJSSS323"},
        };
        public IActionResult Index()
        {
         

            ViewData["customer"] = CustomerList;
            return View();
        }
    }
}

