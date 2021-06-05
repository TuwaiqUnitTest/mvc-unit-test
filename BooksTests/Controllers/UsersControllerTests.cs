using Microsoft.VisualStudio.TestTools.UnitTesting;
using Books.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Books.Controllers.Tests
{
    [TestClass()]
    public class UsersControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            UsersController UsersController = new UsersController();

            ViewResult result = UsersController.Index() as ViewResult;

            bool IsTrue = result.ViewName == "Index" || result.ViewName == null;

            Assert.IsTrue(IsTrue);
        }
    }
}