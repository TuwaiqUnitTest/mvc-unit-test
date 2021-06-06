using System;
using Shopping.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace App.Tests.Controllers
{

    [TestClass]
    public class CalculatorControllerTest
    {

        [TestMethod]
        public void SummationTest()
        {
            //Arrange
            var controller = new CalculatorController();

            //Act
            int test1 = controller.Sum(4, 10);
            int test2 = controller.Sum(4, -10);

            //Assert
            Assert.AreEqual(14, test1);
            Assert.AreEqual(-6, test2);

        }

        [TestMethod]
        public void DivisionTest()
        {
            //Arrange
            var controller = new CalculatorController();

            //Act
            int test1 = controller.Division(10, 10);
            int test2 = controller.Division(8, 2);

            //Assert
            Assert.AreEqual(1, test1);
            Assert.AreEqual(4, test2);
            Assert.ThrowsException<DivideByZeroException>(() => controller.Division(2, 0));

        }


        [TestMethod]
        public void SubtractionTest()
        {
            //Arrange
            var controller = new CalculatorController();

            //Act
            int test1 = controller.Subtraction(4, 10);
            int test2 = controller.Subtraction(10, 10);

            //Assert
            Assert.AreEqual(-6, test1);
            Assert.AreEqual(0, test2);

        }
    }
}

