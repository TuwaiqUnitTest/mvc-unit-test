using Event_Hall.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_HallTest.Controllers
{
    [TestFixture]
    class CalculatorControllerTest
    {
        
        [Test]
        public void Adding_Two_Numbers_Test()
        {
            //Arrange
            CalculatorController controllerObject = new CalculatorController();
            int expectedResult = 6;

            //Act
            int result = controllerObject.Sum(3, 3);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Subtracting_Two_Numbers_Test()
        {
            //Arrange
            CalculatorController controllerObject = new CalculatorController();
            int expectedResult = 10;

            //Act
            int result = controllerObject.Subtract(13, 3);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Dividing_Two_Numbers_Test()
        {
            //Arrange
            CalculatorController controllerObject = new CalculatorController();
            int expectedResult = 11;

            //Act
            int result1 = controllerObject.Divide(33, 3);

            //Assert
            Assert.AreEqual(expectedResult, result1);
            Assert.Throws<DivideByZeroException>(() =>
            {
                controllerObject.Divide(3, 0);
            });
            
        }
    }
}
