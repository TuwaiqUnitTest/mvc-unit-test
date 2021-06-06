using System;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using UTest_MVC_APP.Controllers;

namespace UTest_MVC_App_Test.Controllers
{
    [TestFixture]
    public class WelcomeControllerTest
    {
        [Test]
        public void IndexTest()
        {
            //Arrange
            CalculatorController ControllerObj = new CalculatorController();

            ////Act
            ViewResult viewResultObj = ControllerObj.Index() as ViewResult;

            ////Assert
            Assert.IsNotNull(viewResultObj);
            Assert.IsTrue(string.IsNullOrEmpty(viewResultObj.ViewName) || viewResultObj.ViewName == "Index");

        }
        [Test]
        public void DividePositiveNumbersTest()
        {
            //Arrange
            CalculatorController ControllerObj = new CalculatorController();

            Assert.AreEqual(50, ControllerObj.divide(100, 2));
            Assert.AreEqual(0.5, ControllerObj.divide(2, 4));
        }
        [Test]
        public void DivideOneNigativeNumberTest()
        {
            CalculatorController ControllerObj = new CalculatorController();

            Assert.AreEqual(-50, ControllerObj.divide(100, -2));
            Assert.AreEqual(0, ControllerObj.divide(0, -2));
            Assert.AreEqual(-50, ControllerObj.divide(-100, 2));

        }
        [Test]
        public void DivideTwoNigativeNumbersTest()
        {
            //Arrange
            CalculatorController ControllerObj = new CalculatorController();

            Assert.AreEqual(50, ControllerObj.divide(-100, -2));
            Assert.AreEqual(0.5, ControllerObj.divide(-2, -4));

        }
        [Test]
        public void DivideByZeroTest()
        {
            //Arrange
            CalculatorController ControllerObj = new CalculatorController();

            Assert.Throws<DivideByZeroException>(() => ControllerObj.divide(100, 0));
        }
        [Test]
        public void multiplyPositiveNumbersTest()
        {
            CalculatorController ControllerObj = new CalculatorController();

            Assert.AreEqual(20, ControllerObj.multiply(4, 5));
            Assert.AreEqual(20, ControllerObj.multiply(4, 5));
            Assert.AreEqual(40, ControllerObj.multiply(10, 4));

        }
        [Test]
        public void multiplyByNigativeNumbersTest()
        {
            CalculatorController ControllerObj = new CalculatorController();

            Assert.AreEqual(-40, ControllerObj.multiply(-2, 20));
            Assert.AreEqual(40, ControllerObj.multiply(-2, -20));
        }
        [Test]
        public void multiplyByZeroTest()
        {
            CalculatorController ControllerObj = new CalculatorController();

            Assert.AreEqual(0, ControllerObj.multiply(0, -200));
            Assert.AreEqual(0, ControllerObj.multiply(66, 0));
        }
        
    }

}
