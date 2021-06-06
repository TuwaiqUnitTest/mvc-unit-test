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
        public void DivTestPositiveNum() 
        {
            //Arange 
            CalculatorController controllerOBJ = new CalculatorController();

            //Act

            float test1 = controllerOBJ.Div(4,2) ;

            //Assert

            Assert.AreEqual(2,test1);
            

        }

        public void DivTestNegativeNum()
        {
            //Arange 
            CalculatorController controllerOBJ = new CalculatorController();

            //Act

            float test3 = controllerOBJ.Div(4, -2);

            //Assert

            Assert.AreEqual(-2, test3);


        }

        public void DivTestByZero()
        {
            //Arange 
            CalculatorController controllerOBJ = new CalculatorController();

            //Act


            //Assert
            Assert.Throws<DivideByZeroException>(() => controllerOBJ.Div(4, 0));


        }

        [Test]
        public void SumTestPositiveNum()
        {
            //Arange 
            CalculatorController controllerOBJ = new CalculatorController();

            //Act

            float test1 = controllerOBJ.Sum(4, 2);

            //Assert

            Assert.AreEqual(6, test1);


        }

        [Test]
        public void SumTestNegativeNum()
        {
            //Arange 
            CalculatorController controllerOBJ = new CalculatorController();

            //Act

            float test2 = controllerOBJ.Sum(4, -2);

            //Assert

            Assert.AreEqual(2, test2);


        }

        [Test]
        public void MultTestPositiveNum()
        {
            //Arange 
            CalculatorController controllerOBJ = new CalculatorController();

            //Act

            float test1 = controllerOBJ.Mult(4, 2);

            //Assert

            Assert.AreEqual(8, test1);


        }

        [Test]
        public void MultTestNegativeNum()
        {
            //Arange 
            CalculatorController controllerOBJ = new CalculatorController();

            //Act

            float test2 = controllerOBJ.Mult(4, -2);

            //Assert

            Assert.AreEqual(-8, test2);


        }


    }
}