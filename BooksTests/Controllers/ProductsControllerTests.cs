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
    public class ProductsControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            ProductsController controller = new ProductsController();

            //Act
            ViewResult result = controller.Index() as ViewResult;


            //Assert
            Assert.AreEqual(null, result.ViewName);
        }

        [TestMethod()]
        public void DetailsTest()
        {
            ProductsController controller = new ProductsController();

            ViewResult result = (ViewResult)controller.Details(2);

            Assert.AreEqual("Details", result.ViewName);
        }

        [TestMethod()]
        public void IndexTest1()
        {
            // Arrange
            ProductsController controller = new ProductsController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.AreNotEqual("Error", result.ViewData["products"]);
        }
    }
}