using Math.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTest
{
    [TestClass]
    public class MathControllersTest
    {
        [TestMethod]
        public void TestSumWithPositiveInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act
            int result = math.sum(1, 2);
            int expectedResult = 3;
            //Assert
            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void TestSumWithNegativeInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act
            int result = math.sum(-1, -2);
            int expectedResult = -3;
            //Assert
            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void TestSumWithOneMinusInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act
            int result = math.sum(-1, 2);
            int expectedResult = 1;
            //Assert
            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void TestSubWithPositiveInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act
            int result = math.Sub(3, 2);
            int expectedResult = 1;
            //Assert
            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void TestSubWithNegativeInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act
            int result = math.Sub(-3,-2);
            int expectedResult =-1;
            //Assert
            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void TestSubWithOneMinusInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act
            int result = math.Sub(-3, 2);
            int expectedResult = -5;
            //Assert
            Assert.AreEqual(expectedResult, result);

        }


        [TestMethod]
        public void TestMuiltWithPositiveInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act
            int result = math.Multi(3, 2);
            int expectedResult = 6;
            //Assert
            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void TestMuiltWithNegativeInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act
            int result = math.Multi(-3, -2);
            int expectedResult = 6;
            //Assert
            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void TestMuiltWithOneMinusInt()
        {
            //Arrange
            MathController math = new MathController();

            //Act
            int result = math.Multi(-3, 2);
            int expectedResult = -6;
            //Assert
            Assert.AreEqual(expectedResult, result);

        }

    }
}
