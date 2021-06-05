using System;
using NUnit.Framework;
using Shooping.Controllers;
using Microsoft.AspNetCore.Mvc;


namespace ShoopingTests
{
    [TestFixture]
    public class Tests
    {
        //Arrange for all tests
        Products controller = new Products();
        [Test]
        public void TestIndexView()
        {
            //1.Test index view is not null //Pass

            //Act
            var result = controller.Index("red","red") as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void TestRandomView()
        {
            //2. Test random view is null //Pass

            //Arrange

            //Act
            var result = controller.Random() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void TestDetailsView()
        {
            //3.Test Details View //Pass

            //Arrange

            //Act
            var result = controller.Details(1) as ViewResult;

            //Assert

            Assert.AreEqual("Details", result.ViewName);
        }

        [Test]
        public void TestDetailsRedirct()
        {
            //4.Test redirct action to index view if we pass id < 0 //Pass

            //Act
            var result = (RedirectToActionResult)controller.Details(-1);

            //Assert
            Assert.AreEqual("Index",result.ActionName);
        }
    }
}