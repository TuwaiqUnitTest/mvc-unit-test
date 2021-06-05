using System;
using System.Web.Mvc;
using NUnit.Framework;
using App.Controllers;

namespace App.Tests.Controllers
{

    [TestFixture]
    public class HelloWorldControllerTest
    {
        [Test]
        public void unitTestIndex()
        {
            //Arrange
            WelcomeController ControllerObj = new WelcomeController();

            //Act
            ViewResult viewResultObj = ControllerObj.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Index", viewResultObj.ViewName);

        }
    }
}