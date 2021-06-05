using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Pets.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Test.ControllerTest
{
    class PetsControllerTest
    {
        [Test]
        public void DetailsTest_ValidId()
        {
            PetsController ControllerObj = new PetsController();

            ViewResult viewResultObj = ControllerObj.Details(3) as ViewResult;

            Assert.AreEqual("Details", viewResultObj.ViewName);
        }
        [Test]
        public void PetsPageTest_viewPage()
        {
            PetsController ControllerObj = new PetsController();

            ViewResult viewResultObj = ControllerObj.PetsPage() as ViewResult;

            Assert.AreEqual("PetsInfo", viewResultObj.ViewName);
        }

    }
}
