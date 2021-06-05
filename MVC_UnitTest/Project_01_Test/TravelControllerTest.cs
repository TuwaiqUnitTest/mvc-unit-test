using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_01_Turki.Controllers;

namespace Project_01_Test
{
    [TestClass]
    public class TravelControllerTest
    {
        [TestMethod]
        public void TestIndexView()
        {
            //Arrange
            var controller = new TravelController();

            //Act
            var result = controller.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void TestIndexViewDoesNotReturnNull()
        {
            //Arrange
            var controller = new TravelController();

            //Act
            var view = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(view);


        }
    }
}
