using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Controllers;

namespace CalculatorTest.Controllers
{
    [TestFixture]
    class CalculatorControllerTest
    {
        [Test]
        public void TestSumMethod()
        {

            //Arrange
            CalculatorController calc = new CalculatorController();

            //Act
            float result = calc.Sum(9, 1);

            //Assert
            Assert.AreEqual(10, result);
        }
        [Test]
        public void TestSubMethod()
        {

            //Arrange
            CalculatorController calc = new CalculatorController();

            //Act
            float result = calc.Sub(6, 3);

            //Assert
            Assert.AreEqual(3, result);
        }
        [Test]
        public void TestMulMethod()
        {

            //Arrange
            CalculatorController calc = new CalculatorController();

            //Act
            float result = calc.Mul(3, 2);

            //Assert
            Assert.AreEqual(6, result);
        }
    }
}
