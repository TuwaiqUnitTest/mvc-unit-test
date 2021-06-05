using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Project01_ASP.NET_MVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_ASP.NET_MVCTest.Controllers
{
    [TestFixture]
    class BooksControllerTest
    {

        [Test]
        public void IndexViewReturnedCorrectly()
        {
            BooksController controller = new BooksController();

            ViewResult viewObj = (ViewResult)controller.Index();

            Assert.AreEqual("Index", viewObj.ViewName);
        }

        [Test]
        public void Return404ifNotFound()
        {
            BooksController controller = new BooksController();

            ViewResult viewObj = (ViewResult)controller.Detail(999);

            Assert.AreEqual("fof", viewObj.ViewName);
        }

    }
}
