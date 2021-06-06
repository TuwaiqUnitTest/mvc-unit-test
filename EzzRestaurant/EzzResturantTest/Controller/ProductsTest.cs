using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzzRestaurant.Controllers;
using EzzRestaurant.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace EzzResturantTest.Controller
{
    [TestFixture]
    public class ProductsTest
    {

        [Test]
        public void Index_Action_ViewData_NotNull()
        {
            // Arrange
            ProductsController productsController = new ProductsController();

            // Act
            ViewResult result = productsController.Index() as ViewResult;

            // Assert
            Assert.NotNull(result.ViewData["Products"]);
        }
        
        [Test]
        public void Index_Action_ViewData_isProductList()
        {
            // Arrange
            ProductsController productsController = new ProductsController();

            // Act
            ViewResult result = productsController.Index() as ViewResult;


            // Assert
            Assert.IsInstanceOf(typeof(List<ProductModel>), result.ViewData["Products"]);
        }
        
        public void Index_Action_View_isIndex()
        {
            // Arrange
            ProductsController productsController = new ProductsController();

            // Act
            ViewResult result = productsController.Index() as ViewResult;


            // Assert
            Assert.AreEqual("Index" , result.ViewName);
        }
    }
}
