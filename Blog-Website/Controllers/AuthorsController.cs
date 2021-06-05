using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog_Website.Models;

namespace Blog_Website.Controllers
{
    public class AuthorsController : Controller
    {

        public List<UserModel> authors = new List<UserModel>() {
         new UserModel(1,"Kirsten Korosec","KirstenKorosec@gmail.com","https://res.cloudinary.com/crunchbase-production/image/upload/c_thumb,h_256,w_256,f_auto,g_faces,z_0.7,q_auto:eco/tluillv6dybajfj7i0dq","https://images.pexels.com/photos/946351/pexels-photo-946351.jpeg?w=500&h=650&auto=compress&cs=tinysrgb"),
         new UserModel(2,"Devin Coldewey","DevinColdewey@gmail.com","https://media-cldnry.s-nbcnews.com/image/upload/newscms/2014_01/95471/2503781351_7feef38a1a_b-95471.jpg","https://images.pexels.com/photos/3692749/pexels-photo-3692749.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"),
         new UserModel(3,"Rebecca Bellan","RebeccaBellan,@gmail.com","https://www.monteirolobato.edu.br/public/assets/admin/images/avatars/avatar5_big.png","https://images.pexels.com/photos/4500796/pexels-photo-4500796.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"),
         new UserModel(4,"Amanda Silberling","AmandaSilberling@gmail.com","https://kenyonreview.b-cdn.net/site/wp-content/uploads/Silberling-Amanda.jpg","https://images.pexels.com/photos/1144687/pexels-photo-1144687.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500")
       };

        public IActionResult Index()
        {
            ViewData["authors"] = authors;


            return View("Index");
        }
    }
}
