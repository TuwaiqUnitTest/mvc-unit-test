using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Paradise.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadiseTest.Controllers
{
    [TestFixture]
    class CommunityControllerTest
    {
        [Test]
        public void Index_Admin_AreEqual()
        {
            //Arrange
            CommunityController communityController = new CommunityController();

            //Act
            ViewResult viewResult = communityController.Index("admin") as ViewResult;

            //Assert
            Assert.AreEqual("Admin", viewResult.ViewName);
        }

        [Test]
        public void Index_User_AreEqual()
        {
            //Arrange
            CommunityController communityController = new CommunityController();

            //Act
            ViewResult viewResult = communityController.Index("user") as ViewResult;

            //Assert
            Assert.AreEqual("User", viewResult.ViewName);
        }
        [Test]
        public void Index_Empty_AreEqual()
        {
            //Arrange
            CommunityController communityController = new CommunityController();

            //Act
            ViewResult viewResult = communityController.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Index", viewResult.ViewName);
        }
    }
}
