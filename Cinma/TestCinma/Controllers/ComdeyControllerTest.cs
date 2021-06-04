using Cinma.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestCinma.Controllers
{
    [TestClass]
    class ComdeyControllerTest

    {
        [TestMethod]
        public void Index()
        {
            ComdeyController co = new ComdeyController();
            var viewResultObj = co.Index() as ViewResult;
            Assert.AreEqual("Index", viewResultObj.ViewName);
        }
        [TestMethod]
        public void Index_Data()
        {
            ComdeyController controller = new ComdeyController();
            var viewResultObj2 = controller.Index() as ViewResult;
            Assert.AreEqual("Hababam Sinifi", viewResultObj2.ViewData["comdeyLis"]);

        }

    }
}
