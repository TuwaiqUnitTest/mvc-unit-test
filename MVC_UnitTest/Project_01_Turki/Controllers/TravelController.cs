using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Project_01_Turki.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project_01_Turki.Controllers
{
    public class TravelController : Controller
    {
        List<TravelViewModel> cts = new List<TravelViewModel>() {
            new TravelViewModel(){Name = "Riyadh", AverageTemp = 26, bestMonthToVisit = "September, October, November, December, January, February, March", Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQji9k5PIrtD-rwEG_C1kx_K6xY6-Stw-_uwQ&usqp=CAU"},
            new TravelViewModel(){Name = "Abha", AverageTemp = 13, bestMonthToVisit = "March, April, May, June, July, August", Url = "https://vid.alarabiya.net/images/2020/05/09/4bbe314b-4c4f-4ac9-9a91-582efd566d50/4bbe314b-4c4f-4ac9-9a91-582efd566d50_16x9_1200x676.jpg?width=1138"},
            new TravelViewModel(){Name = "Al `Ula", AverageTemp = 17, bestMonthToVisit = "September, October, November, December, January, February, March", Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSIUyWhWj3YeMwapNaCWWDXk73EJDtSTdxbbA&usqp=CAU" },
            new TravelViewModel(){Name = "Jeddah", AverageTemp = 23, bestMonthToVisit = "September, October, November, December, January, February, March", Url = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/15/0d/89/b2/caption.jpg?w=900&h=-1&s=1" },
            new TravelViewModel(){Name = "Makkah", AverageTemp = 22, bestMonthToVisit = "September, October, November, December, January, February, March", Url = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1c/d0/65/9e/exterior-view.jpg?w=1000&h=-1&s=1" },
            new TravelViewModel(){Name = "Al Lith", AverageTemp = 21, bestMonthToVisit = "September, October, November, December, January, February, March", Url = "https://www.elzmannews.com/img/20/05/05/15886410048471078.JPG" },
            new TravelViewModel(){Name = "Tabuk", AverageTemp = 14, bestMonthToVisit = "September, October, November, December, January, February, March", Url = "https://i.pinimg.com/originals/81/01/23/810123ba5a64dba20b63d0fd8d656484.jpg" },
            new TravelViewModel(){Name = "Yanbu", AverageTemp = 21, bestMonthToVisit = "September, October, November, December, January, February, March", Url = "https://i.ytimg.com/vi/cnqB6G7shoI/maxresdefault.jpg" },
            new TravelViewModel(){Name = "Jizan", AverageTemp = 22, bestMonthToVisit = "September, October, November, December, January, February, March", Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ2skL2Cp5ajxxQuGQa7abVpIhEUbg2tlEWpw&usqp=CAU" },
            new TravelViewModel(){Name = "Dammam", AverageTemp = 25, bestMonthToVisit = "September, October, November, December, January, February, March", Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ7IMF4KA_BtU-NACOjIV0D9OWUE0-Hi9lX6g&usqp=CAU" },
            new TravelViewModel(){Name = "Al Khobar", AverageTemp = 25, bestMonthToVisit = "September, October, November, December, January, February, March", Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSn7VenqPg7i60W9_Nxi1RDsUgdMrpjWGiJ5w&usqp=CAU"},
            new TravelViewModel(){Name = "Taif", AverageTemp = 17, bestMonthToVisit = "March, April, May, June, July, August", Url = "https://3tab.net/wp-content/uploads/2019/06/12201.jpg"},
            new TravelViewModel(){Name = "Khamis Mushait", AverageTemp = 18, bestMonthToVisit = "March, April, May, June, July, August", Url = "https://res.cloudinary.com/protenders/image/upload/c_limit,d_missing,dpr_3.0,f_auto,fl_progressive:semi,q_auto:eco,w_500/sbjtzo12bc4tof9btagl.jpg"}

        };

        // GET: /<controller>/
        public IActionResult Index()
        {
            if (cts.Count >= 1)
            {
                ViewBag.cts = cts;
                return View("Index");   
            }
            return View("Error");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
