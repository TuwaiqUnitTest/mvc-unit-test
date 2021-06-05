using App.Controllers;
using NUnit.Framework;
using System.Web.Mvc;

namespace App.Tests.Controllers
{
    [TestFixture]
    class CalculatorControllerTest
    {
        [Test]
        public void SumTest()
        {
            //Arrange
            CalculatorController ControllerObj = new CalculatorController();

            //Act
            ViewResult viewResultObj = ControllerObj.Sum(5,5) as ViewResult;

            //Assert
            Assert.AreEqual("10", viewResultObj.ViewData["result"]);
        }

        [Test]
        public void SubTest()
        {
            //Arrange
            CalculatorController ControllerObj = new CalculatorController();

            //Act
            ViewResult viewResultObj = ControllerObj.Sub(5, 5) as ViewResult;

            //Assert
            Assert.AreEqual("1", viewResultObj.ViewData["result"]);
        }

        [Test]
        public void MulTest()
        {
            //Arrange
            CalculatorController ControllerObj = new CalculatorController();

            //Act
            ViewResult viewResultObj = ControllerObj.Mul(5, 5) as ViewResult;

            //Assert
            Assert.AreEqual("25", viewResultObj.ViewData["result"]);
        }

        [Test]
        public void DivTest()
        {
            //Arrange
            CalculatorController ControllerObj = new CalculatorController();

            //Act
            ViewResult viewResultObj = ControllerObj.Div(5, 5) as ViewResult;

            //Assert
            Assert.AreEqual("0", viewResultObj.ViewData["result"]);
        }
    }
}
