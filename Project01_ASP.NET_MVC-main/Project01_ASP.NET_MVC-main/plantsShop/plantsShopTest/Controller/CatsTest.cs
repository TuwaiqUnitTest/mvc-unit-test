using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using plantsShop.Controllers;
using Microsoft.AspNetCore.Mvc;


namespace plantsShopTest.Controller
{
    [TestClass]
    public class CatsTest
    {
        [TestMethod]
        public void IndexActionView()
        {
            var con = new CatsController();

            var res = con.Index() as ViewResult;

            Assert.AreEqual("Index", res.ViewName);
        }
        
        [TestMethod]
        public void IndexActionViewDataIsNotNull()
        {
            var con = new CatsController();

            var res = con.Index() as ViewResult;

            Assert.IsNotNull(res.ViewData["Cats"]);
        }

        [TestMethod]
        public void DetailsActionViewDataIsNotNull()
        {
            var con = new CatsController();

            var res = con.Details() as ViewResult;

            Assert.IsNotNull(res.ViewData["Cat"]);
        }
        
        [TestMethod]
        public void DetailsActionView()
        {
            var con = new CatsController();

            var res = con.Details() as ViewResult;

            Assert.AreEqual("Details", res.ViewName);
        }
    }
}
