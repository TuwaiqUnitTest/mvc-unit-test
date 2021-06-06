using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Controllers;

namespace CalculatorTest.Calculator
{
    class CalculatorTest
    {
        [TestMethod]
        public void Addition()
        {
            //Arange
            CalculatorController cal = new CalculatorController();

            //Act
            int result = cal.Add(5, 10);
            //Assert
            Assert.AreEqual(15, result);
          
        }
        [TestMethod]
        public void Subtraction()
        {
            //Arange
            CalculatorController cal = new CalculatorController();

            //Act
            int result = cal.Sub(200, 100);
            //Assert
            Assert.AreEqual(100, result);
    
        }
        [TestMethod]
        public void Multiplication()
        {
            //Arange
            CalculatorController cal = new CalculatorController();

            //Act
            int result = cal.Mul(4, 100);
       

            //Assert
            Assert.AreEqual(400, result);
         
        }
        [TestMethod]
        public void Division()
        {
            //Arange
            CalculatorController cal = new CalculatorController();

            //Act
            int result = cal.Div(18, 6);
         

            //Assert
            Assert.AreEqual(3, result);
        
        }
    }
}




