using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Controllers.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        HomeController home = new HomeController();
        [TestMethod]
        public void Addition_TwoPositiveNumbers_Calculated()
        {
            // Arrange
            int number1 = 15;
            int number2 = 5;
            int expectedResult = 20;

            //Act
            int result = home.Addition(number1,number2);

            //Assert
            
            Assert.AreEqual(expectedResult, result, 0.001);
        }
        [TestMethod]
        public void Addition_NegativeNumberToPositiveNumber_Calculated()
        {
            // Arrange
            int number1 = 15;
            int number2 = -5;
            int expectedResult = 10;

            //Act
            int result = home.Addition(number1, number2);

            //Assert

            Assert.AreEqual(expectedResult, result, 0.001);
        }
        [TestMethod]
        public void Addition_PositiveNumberToNegativeNumber_Calculated()
        {
            // Arrange
            int number1 = 15;
            int number2 = -5;
            int expectedResult = 10;

            //Act
            int result = home.Addition(number2, number1);

            //Assert

            Assert.AreEqual(expectedResult, result, 0.001);
        }
        [TestMethod]
        public void Addition_ZeroToPositiveInteger_Calculated()
        {
            // Arrange
            int number1 = 15;
            int number2 = 0;
            int expectedResult = 15;

            //Act
            int result = home.Addition(number2, number1);

            //Assert

            Assert.AreEqual(expectedResult, result, 0.001);
        }
        [TestMethod]
        public void Addition_ZeroToNegativeInteger_Calculated()
        {
            // Arrange
            int number1 = 0;
            int number2 = -5;
            int expectedResult = -5;

            //Act
            int result = home.Addition(number1, number2);

            //Assert

            Assert.AreEqual(expectedResult, result, 0.001);
        }



        //SUBTRACTION FUNCTION:
        [TestMethod]
        public void Subtraction_TwoPositives_Calculated()
        {
            // Arrange
            int number1 = 15;
            int number2 = 5;
            int expectedResult = 10;

            //Act
            int result = home.Subtraction(number1, number2);

            //Assert

            Assert.AreEqual(expectedResult, result, 0.001);
        }
        [TestMethod]
        public void Subtraction_ZeroFromPositive_Calculated()
        {
            // Arrange
            int number1 = 0;
            int number2 = 5;
            int expectedResult = -5;

            //Act
            int result = home.Subtraction(number1, number2);

            //Assert

            Assert.AreEqual(expectedResult, result, 0.001);
        }
        [TestMethod]
        public void Subtraction_ZeroFromNegative_Calculated()
        {
            // Arrange
            int number1 = 0;
            int number2 = -5;
            int expectedResult = 5;

            //Act
            int result = home.Subtraction(number1, number2);

            //Assert

            Assert.AreEqual(expectedResult, result, 0.001);
        }
        [TestMethod]
        public void Subtraction_NegativeFromNegative_Calculated()
        {
            // Arrange
            int number1 = -10;
            int number2 = -5;
            int expectedResult = -5;

            //Act
            int result = home.Subtraction(number1, number2);

            //Assert

            Assert.AreEqual(expectedResult, result, 0.001);
        }
        [TestMethod]
        public void Subtraction_NegativeFromPositive_Calculated()
        {
            // Arrange
            int number1 = -5;
            int number2 = 10;
            int expectedResult = -15;

            //Act
            int result = home.Subtraction(number1, number2);

            //Assert

            Assert.AreEqual(expectedResult, result, 0.001);
        }
        [TestMethod]
        public void Subtraction_PositiveFromNegative_Calculated()
        {
            // Arrange
            int number1 = 5;
            int number2 = -15;
            int expectedResult = 20;

            //Act
            int result = home.Subtraction(number1, number2);

            //Assert

            Assert.AreEqual(expectedResult, result, 0.001);
        }





        //DIVISION FUNCTION:
        [TestMethod]
        public void Division_PositiveFromPositive_Calculated()
        {
            // Arrange
            int number1 = 15;
            int number2 = 3;
            int expectedResult = 5;

            //Act
            int result = home.Division(number1, number2);

            //Assert

            Assert.AreEqual(expectedResult, result, 0.001);
        }

        [TestMethod]
        public void Division_ZeroFromPositive_Calculated()
        {
            // Arrange
            int number1 = 0;
            int number2 = 10;
            int expectedResult = 0;

            //Act
            int result = home.Division(number1, number2);

            //Assert

            Assert.AreEqual(expectedResult, result, 0.001);
        }
        [TestMethod]
        public void Division_NegativeFromPositive_Calculated()
        {
            // Arrange
            int number1 = -500;
            int number2 = 50;
            int expectedResult = -10;

            //Act
            int result = home.Division(number1, number2);

            //Assert

            Assert.AreEqual(expectedResult, result, 0.001);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Division_PositiveFromZero_ThrowException()
        {
            // Arrange
            int number1 = 5;
            int number2 = 0;
            //double expectedResult = 0;

            //Act
            int result = home.Division(number1, number2);

            //Assert
           // Assert.AreEqual(expectedResult, result, 0.001);
            Assert.ThrowsException<DivideByZeroException>(() => home.Division(number1, number2));
        }
    }
}