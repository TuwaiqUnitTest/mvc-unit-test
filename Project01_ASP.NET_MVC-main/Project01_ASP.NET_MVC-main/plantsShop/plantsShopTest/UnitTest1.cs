using Microsoft.VisualStudio.TestTools.UnitTesting;
using plantsShop.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace plantsShopTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var con = new CatsController();

            var res = con.Index() as ViewResult;

            Assert.AreEqual("Index", res.ViewName);
        }
    }
}
