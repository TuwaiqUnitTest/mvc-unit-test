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
    public class ShopsTest
    {
        [TestMethod]
        public void IndexActionView()
        {
            var shope= new ShopsController();

            var res = shope.Index() as ViewResult;

            Assert.AreEqual("Index", res.ViewName);
        }

        [TestMethod]
        public void IndexActionViewDataIsNotNull()
        {
            var shope = new ShopsController();

            var res = shope.Index() as ViewResult;

            Assert.IsNotNull(res.ViewData["Shops"]);
        }
    }
}
