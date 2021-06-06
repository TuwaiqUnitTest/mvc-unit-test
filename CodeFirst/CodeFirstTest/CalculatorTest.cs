using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Controllers;

namespace CodeFirstTest
{

    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void sumTest()
        {
            // Arrange
            Calculator cal = new Calculator();

            //Act
            var a = cal.sum(1, 2);
            var b = cal.div(5, 0);

            //Assert
            Assert.AreEqual(3, a);
            Assert.AreEqual(0, b);
            Assert.IsNotNull(a);

        }
    }
}
