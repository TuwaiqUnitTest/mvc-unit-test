using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.Controllers;
using System.Linq;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Min()
        {
            // Arrange
            var controller = new HomeController();
            int[] myNum = { 10, 20, 30, 40 };


            // Act
            var result = (ViewResult)controller.Min();

            var expectedMin = myNum.Min();

            // Assert
            Assert.AreEqual(expectedMin, result.ViewData["Min"]);
        }

        [TestMethod]
        public void Max()
        {
            // Arrange
            var controller = new HomeController();
            int[] myNum = { 10, 20, 30, 40 };


            // Act
            var result = (ViewResult)controller.Max();

            var expectedMin = myNum.Max();

            // Assert
            Assert.AreEqual(expectedMin, result.ViewData["Max"]);
        }

        [TestMethod]
        public void Sum()
        {
            // Arrange
            var controller = new HomeController();
            int[] myNum = { 10, 20, 30, 40 };


            // Act
            var result = (ViewResult)controller.Sum();

            var expectedMin = myNum.Sum();

            // Assert
            Assert.AreEqual(expectedMin, result.ViewData["Sum"]);
        }
    }
}
