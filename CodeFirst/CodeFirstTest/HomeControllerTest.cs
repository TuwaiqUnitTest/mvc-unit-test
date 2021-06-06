using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeFirst;
using CodeFirst.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeFirstTest
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void TestIndex()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var view = (ViewResult)controller.Index();
            
            

            // Assert
            Assert.AreEqual("Index", view.ViewName);
            
        }
    }
}
