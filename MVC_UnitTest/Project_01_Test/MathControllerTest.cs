using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_01_Turki.Controllers;

namespace Project_01_Test
{
    [TestClass]
    public class MathControllerTest
    {
        [TestMethod]
        public void TestSumMethod()
        {
            //Arrange
            var controller = new MathController();
            int expected = 12;

            //Act
            int result = controller.Sum(4, 8);

            //Assert
            Assert.AreEqual(expected, result);
            
        }

        [TestMethod]
        public void TestSubMethod()
        {
            //Arrange
            var controller = new MathController();
            int expected = 3;

            //Act
            int result = controller.Sub(10, 7);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestDivMethod()
        {
            //Arrange
            var controller = new MathController();
            int expected = 5;

            //Act
            int result = controller.Div(20, 4);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGBToMBMethod()
        {
            //Arrange
            var controller = new MathController();
            int expected = 5120;

            //Act
            int result = controller.GBToMB(5);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMBToGBMethod()
        {
            //Arrange
            var controller = new MathController();
            int expected = 2;

            //Act
            int result = controller.MBToGB(2048);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
