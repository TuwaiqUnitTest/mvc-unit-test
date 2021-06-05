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
    class AuthorControllerTest
    {

        [Test]
        public void IndexViewReturnedCorrectly()
        {
            AuthorsController controller = new AuthorsController();

            ViewResult viewObj = (ViewResult)controller.Index();

            Assert.AreEqual("Index", viewObj.ViewName);
        }

        [Test]
        public void ReturnDetailsOfOneAuthor()
        {
            AuthorsController controller = new AuthorsController();

            ViewResult viewObj = (ViewResult)controller.Detail(2);

            Assert.AreEqual("Detail", viewObj.ViewName);
        }

    }
}
