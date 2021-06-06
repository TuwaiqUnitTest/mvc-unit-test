using Caulculations.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaulculationsTests
{
    [TestClass]
    public class CalculationControllerTest
    {

        [TestMethod]
        public void TestAdditionOfPositiveIntegers()
        {
            //Arrange
            CaulculationController calculation = new CaulculationController();

            //Act
            int result = calculation.Addition(6, 5);

            //Assert
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void TestAdditionOfNegativeIntegers()
        {
            //Arrange
            CaulculationController calculation = new CaulculationController();

            //Act
            int result = calculation.Addition(-6, -5);

            //Assert
            Assert.AreEqual(-11, result);
        }

        [TestMethod]
        public void TestAdditionOfNegativeIntegerAndPositiveInteger()
        {
            //Arrange
            CaulculationController calculation = new CaulculationController();

            //Act
            int result = calculation.Addition(-6, 5);

            //Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestSubtractionOfPositiveIntegers()
        {
            //Arrange
            CaulculationController calculation = new CaulculationController();

            //Act
            int result = calculation.Subtraction(6, 5);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestSubtractionOfNegativeIntegers()
        {
            //Arrange
            CaulculationController calculation = new CaulculationController();

            //Act
            int result = calculation.Subtraction(-6, -5);

            //Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestSubtractionOfNegativeIntegerAndPositiveInteger()
        {
            //Arrange
            CaulculationController calculation = new CaulculationController();

            //Act
            int result = calculation.Subtraction(-6, 5);

            //Assert
            Assert.AreEqual(-11, result);
        }

        [TestMethod]
        public void TestMultiplicationOfPositiveIntegers()
        {
            //Arrange
            CaulculationController calculation = new CaulculationController();

            //Act
            int result = calculation.Multiplication(6, 5);

            //Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void TestMultiplicationOfNegativeIntegers()
        {
            //Arrange
            CaulculationController calculation = new CaulculationController();

            //Act
            int result = calculation.Multiplication(-6, -5);

            //Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void TestMultiplicationOfNegativeIntegerAndPositiveInteger()
        {
            //Arrange
            CaulculationController calculation = new CaulculationController();

            //Act
            int result = calculation.Multiplication(-6, 5);

            //Assert
            Assert.AreEqual(-30, result);
        }




    }
}
