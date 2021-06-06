using Calculator.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorTest.Controllers
{
    [TestClass]
    public class CalculatorControllerTest
    {


        [TestMethod]
        public void SumTest()
        {
            //Arange

            CalculatorController OBJ = new CalculatorController();

            //Act

            int test1 = OBJ.Sum(4, 4);
            int test2 = OBJ.Sum(4, -0);

            //Assert

            Assert.AreEqual(8, test1);
            Assert.AreEqual(4, test2);


        }

        [TestMethod]
        public void SubTest()
        {
            //Arange 
            CalculatorController OBJ = new CalculatorController();

            //Act

            int test1 = OBJ.Sub(4, 2);
            int test2 = OBJ.Sub(4, -3);

            //Assert

            Assert.AreEqual(2, test1);
            Assert.AreEqual(7, test2);


        }

        [TestMethod]
        public void DivTest()
        {
            //Arange

            CalculatorController OBJ = new CalculatorController();

            //Act

            int test1 = OBJ.Div(8, 2);
            int test2 = OBJ.Div(4, -2);

            //Assert

            Assert.AreEqual(4, test1);
            Assert.AreEqual(-2, test2);
            Assert.ThrowsException<DivideByZeroException>(() => OBJ.Div(2, 0));


        }
    }
}
