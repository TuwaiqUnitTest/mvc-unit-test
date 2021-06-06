using Microsoft.VisualStudio.TestTools.UnitTesting;
using Books.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Controllers.Tests
{
    [TestClass()]
    public class CalculatorControllerTests
    {
        [TestMethod()]
        public void MulTest()
        {
            //Arange
            CalculatorController Calculato = new CalculatorController();
            //Act
            int result = Calculato.Mul(2, 10);
            //Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod()]
        public void DivTest()
        {
            //Arange
            CalculatorController Calculato = new CalculatorController();
            //Act
            int result = Calculato.Div(36, 4);


            //Assert
            Assert.AreEqual(9, result);
        }
    }
}