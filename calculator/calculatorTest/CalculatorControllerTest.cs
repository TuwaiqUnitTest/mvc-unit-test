using System;
using calculator.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace calculatorTest
{
    public class Tests
    {
      
        [Test]
        public void Multiplication()
        {
            CalculatorController m = new CalculatorController();

            float t1 = m.Multiplication(3, 5); // expected 15 
            float t2 = m.Multiplication(-3, 5); // expected -15 
            float t3 = m.Multiplication(-3, -3); // expected 9 

            Assert.AreEqual(15,t1);
            Assert.AreEqual(-15,t2);
            Assert.AreEqual(9,t3);
            
        }

        [Test]
        public void Div()
        {
            CalculatorController m = new CalculatorController();
            float t1 = m.Div(15, 5); // expected 3 
            float t2 = m.Div(15, -5); // expected -3 
            float t3 = m.Div(-16, -4); // expected 4 

            Assert.Throws<Exception>(() => m.Div(7, 0)); 
            Assert.AreEqual(3,t1);
            Assert.AreEqual(-3,t2);
            Assert.AreEqual(4,t3);
        }

        [Test]
        public void Addition()
        {
            CalculatorController m = new CalculatorController();
            float t1 = m.Addition(3, 5); // expected 8 
            float t2 = m.Addition(-3, 5); // expected 2 
            float t3 = m.Addition(-3, -3); // expected -6
            
            
            Assert.AreEqual(8,t1);
            Assert.AreEqual(2,t2);
            Assert.AreEqual(-6,t3);
        }
    }
}