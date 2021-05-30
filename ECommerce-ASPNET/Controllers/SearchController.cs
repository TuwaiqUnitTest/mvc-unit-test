using ECommerce_ASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_ASPNET.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ErrorMessage"] = HttpContext.Request.Query["err_msg"].ToString();
            return View();
        }

        public IActionResult Find()
        {
            var query = HttpContext.Request.Query["q"].ToString();

            if (string.IsNullOrEmpty(query)) return Redirect("~/Search");

            ViewData["Products"] = ProductsController.Products().FindAll(
                p => 
                    (
                        p.Title.Contains(query)
                        || p.Description.Contains(query)
                        || p.Category.Title.Contains(query)
                    )
                );

            if (((List<ProductModel>)ViewData["Products"]).Count == 0) return Redirect("~/Search?err_msg=No match");

            return View("~/Views/Products/Index.cshtml");
        }
    }
}
