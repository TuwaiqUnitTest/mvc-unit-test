using Microsoft.VisualStudio.TestTools.UnitTesting;
using unit.Controllers;

namespace unitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSumWithPostiveInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act

            int result = math.sum(1, 2);

            int expectedResult = 3;

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestSumWithNegativeAndPositiveInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act

            int result = math.sum(-10, 2);

            int expectedResult = -8;

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestSumWithTwoNegativeInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act

            int result = math.sum(-452 , - 99);

            int expectedResult = -551;//actually it should be -551

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestSubWithPositiveFirstIsGreaterThanSecondInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act

            int result = math.sub( 88,30);

            int expectedResult = 58;

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestSubWithPositiveSecondIsGreaterThanFirstInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act

            int result = math.sub(34 , 50);

            int expectedResult = -16;//actual result is -16

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestSubWithTwoNegativeInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act

            int result = math.sub(-34, -50);

            int expectedResult = 16;//

            //Assert
            Assert.AreEqual(result, expectedResult);
        }


        [TestMethod]
        public void TestMultWithTwoPositivetiveInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act

            int result = math.mult(2, 4);

            int expectedResult = 12;//

            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        public void TestMultWithTwoNegativetiveInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act

            int result = math.mult(-2, -4);

            int expectedResult = 8;//

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        public void TestMultWithTwoNegativetiveAndPositiveInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act

            int result = math.mult(-2, 4);

            int expectedResult = -8;//

            //Assert
            Assert.AreEqual(result, expectedResult);
        }


    }
}
