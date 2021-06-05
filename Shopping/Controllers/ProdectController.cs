using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Models;

namespace Shopping.Controllers
{

    public class ProdectController : Controller
    {

        List<Prodect> list = new List<Prodect>
        {
            new Prodect {Prodect_Id = 1 , Prodect_Name ="Monkey Doll" ,Prodect_Price=54.14 ,
                Prodect_Image ="https://h.top4top.io/p_1974x07621.jpeg" },
            new Prodect {Prodect_Id = 2 , Prodect_Name ="Eat Game"
                ,Prodect_Price=32.12 ,
                Prodect_Image ="https://i.top4top.io/p_19743lqmo2.jpeg" },
            new Prodect {Prodect_Id = 3 , Prodect_Name ="Chef Doll"
                ,Prodect_Price=66.7 ,
                Prodect_Image ="https://j.top4top.io/p_19749or6h3.jpeg" },
              new Prodect {Prodect_Id = 4 , Prodect_Name ="Deer Doll"
                ,Prodect_Price=124 ,
                Prodect_Image ="https://k.top4top.io/p_1974k7oac4.jpeg" },
                new Prodect {Prodect_Id = 5 , Prodect_Name ="Dino Activity Toy" ,Prodect_Price=54.14 ,
                Prodect_Image ="https://static2.mumzworld.com/media/catalog/product/g/f/gf-6105-hola-baby-toys-learning-dino-activity-toy-1603456002.jpg" },
            new Prodect {Prodect_Id = 6 , Prodect_Name ="Piano Toy"
                ,Prodect_Price=40.20 ,
                Prodect_Image ="https://afafmall.com/wp-content/uploads/2020/09/71p3fkiM-L._AC_SL1500_.jpg" },
            new Prodect {Prodect_Id = 7 , Prodect_Name ="Tent Game"
                ,Prodect_Price=90 ,
                Prodect_Image ="https://images-na.ssl-images-amazon.com/images/I/41UJO56O4CL._AC_SY1000_.jpg" },
              new Prodect {Prodect_Id = 8 , Prodect_Name ="Cooking Game"
                ,Prodect_Price=100 ,
                Prodect_Image ="https://cf4.s3.souqcdn.com/item/2013/10/18/62/55/71/9/item_L_6255719_3485156.jpg" },
              new Prodect {Prodect_Id = 9 , Prodect_Name ="Electric Bicycle" ,Prodect_Price=170 ,
                Prodect_Image ="https://whatt.cc/wp-content/uploads/2018/08/1570.jpg" },
            new Prodect {Prodect_Id = 10 , Prodect_Name ="Jumping game"
                ,Prodect_Price=999.50 ,
                Prodect_Image ="https://media.extra.com/s/aurora/100073558_800/Bestway-Castle-Bouncer-175L-x-173W-x-135H-cm?locale=en-GB,en-*,*&$Listing-Product-2x$" },
            new Prodect {Prodect_Id = 11 , Prodect_Name ="Cooking Games"
                ,Prodect_Price=66.8 ,
                Prodect_Image ="https://i.ytimg.com/vi/LnYMgPdnPRo/maxresdefault.jpg" },
              new Prodect {Prodect_Id = 12 , Prodect_Name ="Car"
                ,Prodect_Price=80 ,
                Prodect_Image ="https://static2.mumzworld.com/media/catalog/product/cache/6/image/440x/9df78eab33525d08d6e5fb8d27136e95/g/t/gt-717000-step2-push-around-buggy-anniversary-edition-red-1555435878.jpg" },

    };


        public IActionResult Index()
        {

            ViewData["Prodect"] = list;

            return View();
        }
        public IActionResult MoreDetails(int? id)
        {
            var listItem = list.Find(element => element.Prodect_Id == id);
            if (listItem == null)
            {
                return Content("No more details about the prodect");
            }
            else
            {
                ViewData["p"] = listItem;
                 
                return View();
            }




        } }
}

    
