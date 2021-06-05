using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Models;

namespace Pets.Controllers
{
    public class PetsController : Controller
    {
        public List<PetsInfoModel> PetsInfo = new List<PetsInfoModel>()
            {
                new PetsInfoModel () {id=1,name="bobby",type="dog",seller="sarah",phoneNo=0554444879,location="Dammam",image="https://images.unsplash.com/photo-1611003228577-e610e9a727c5?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=667&q=80" },
                new PetsInfoModel () {id=2,name="nona",type="cat",seller="abrar",phoneNo=0555333621,location="Riyadh",image="https://images.unsplash.com/photo-1585373683920-671438c82bfa?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=634&q=80"},
                new PetsInfoModel () {id=3,name="alex",type="dog",seller="ahmad",phoneNo=0766622552,location="Dubai",image="https://images.unsplash.com/photo-1507146426996-ef05306b995a?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=750&q=80"},
                new PetsInfoModel () {id=4,name="loffy",type="cat",seller="manal",phoneNo=066633442,location="Riyadh",image="https://images.unsplash.com/photo-1586369730051-51b4f2ad9ca8?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=750&q=80"},
                new PetsInfoModel () {id=5,name="white",type="cat",seller="salwa",phoneNo=088854342,location="Abo dhabi",image="https://images.unsplash.com/photo-1548366086-7f1b76106622?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=624&q=80"},
                new PetsInfoModel () {id=6,name="leo",type="cat",seller="khalid",phoneNo=0554444778,location="Jeddah",image="https://images.unsplash.com/photo-1577544060849-3fc4e4a5ba01?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=675&q=80"}
            };
        public IActionResult PetsPage()
        {
            ViewData["PetsInfo"] = PetsInfo;
            return View("PetsInfo");
        }

        public IActionResult Details(int ? id)
        {
            PetsInfoModel Pet = PetsInfo.Find(b => b.id == id);
            if (Pet == null)
            {
                return RedirectToAction("PetsPage");
            }
            else
            {
                ViewData["Pet"] = Pet;
                return View("Details");
            }
        }
    }
}
