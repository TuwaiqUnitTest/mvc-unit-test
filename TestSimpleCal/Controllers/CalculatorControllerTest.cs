using System;
using NUnit.Framework;
using SimpleCal.Controllers;

namespace TestSimpleCal.Controllers
{
    [TestFixture]
    public class CalculatorControllerTest
    {
       [Test]
       public void TestSumMethodAddingTwoNumbers()
        {
            //Arrange
            ClaculatorController cal = new ClaculatorController();
            //Act
            int result = cal.sum(1,5);
            //Assert
            Assert.AreEqual(6, result);
        }
        [Test]
        public void TestSubMethodDiffrentTowNumbers()
        {
            //Arrange
            ClaculatorController cal = new ClaculatorController();
            //Act
            int result = cal.sub(3 ,2);
            //Assert
            Assert.AreEqual(1, result);
        }
        [Test]
        public void TestMulethodMultiplyTwoNumbers()
        {
            //Arrange
            ClaculatorController cal = new ClaculatorController();
            //Act
            int result = cal.Mul(1, 5);
            //Assert
            Assert.AreEqual(5, result);
        }
    }
}
