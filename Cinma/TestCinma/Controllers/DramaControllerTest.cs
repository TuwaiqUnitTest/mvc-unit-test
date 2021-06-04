using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Cinma.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TestCinma.Controllers
{
        [TestClass]
        public class DramaControllerTest
        {
        [TestMethod]
        public void Details_Else()
        {
            DramaController co = new DramaController();
            var viewResultObj = co.Details(2) as Microsoft.AspNetCore.Mvc.ViewResult;
            Assert.AreEqual("Details", viewResultObj.ViewName);
        }
        [TestMethod]
        public void Details_IF_Then()
        {
            DramaController controller = new DramaController();

            var viewResultObj2 = controller.Details(-1) as Microsoft.AspNetCore.Mvc.RedirectToRouteResult;
            
            Assert.AreEqual("Index", viewResultObj2.RouteValues["action"]);
            Assert.AreEqual("Errors", viewResultObj2.RouteValues["controller"]);

        }
    }
    
}
