using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using ProjectUnitTest.Controllers;
using System;

namespace ProjectUnitTest_Test
{
    public class Tests
    {

        [Test]
        public void IndexTest()
        {
            //Arange 
            CalculatorController controllerOBJ = new CalculatorController();

            //Act

            ViewResult viewResultOBJ = controllerOBJ.Index() as ViewResult;

            //Assert

            Assert.IsNotNull(viewResultOBJ);
            Assert.IsTrue(string.IsNullOrEmpty(viewResultOBJ.ViewName) || viewResultOBJ.ViewName=="Index");

        }
        
            [Test]
        public void DivTest() 
        {
            //Arange 
            CalculatorController controllerOBJ = new CalculatorController();

            //Act

            float test1 = controllerOBJ.Div(4,2) ;
            float test3 = controllerOBJ.Div(4, -2);

            //Assert

            Assert.AreEqual(2,test1);
            Assert.Throws<DivideByZeroException>(()=> controllerOBJ.Div(4,0));
            Assert.AreEqual(-2, test3);
            

        }

        [Test]
        public void SumTest()
        {
            //Arange 
            CalculatorController controllerOBJ = new CalculatorController();

            //Act

            float test1 = controllerOBJ.Sum(4, 2);
            float test2 = controllerOBJ.Sum(4, -2);

            //Assert

            Assert.AreEqual(6, test1);
            Assert.AreEqual(2, test2);


        }

        [Test]
        public void MultTest()
        {
            //Arange 
            CalculatorController controllerOBJ = new CalculatorController();

            //Act

            float test1 = controllerOBJ.Mult(4, 2);
            float test2 = controllerOBJ.Mult(4, -2);

            //Assert

            Assert.AreEqual(8, test1);
            Assert.AreEqual(-8, test2);


        }
    }
}