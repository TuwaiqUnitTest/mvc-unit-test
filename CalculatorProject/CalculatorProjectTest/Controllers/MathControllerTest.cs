using CalculatorProject.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorProjectTest
{
    [TestClass]
    public class MathControllerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void Index_IsEqualIndexView_ReturnIndexView()
        {
             //Arrange
             MathController index = new MathController();

            //Act
            ViewResult indexresult = index.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Index",indexresult.ViewName);
        }
        [TestMethod]
        public void SumNumber_SumPostiveNumberWithPositve_ReturnPositiveNumber()
        {
            int number1 = 5;
            int number2 = 5;

            //Arrange
            MathController math = new MathController();
            //Act
            int result = math.SumNumber(number1, number2);

            //Asset
            Assert.AreEqual(result, 10);
        }
        [TestMethod]
        public void SumNumber_SumNullValueWithNullValue_ReturnIsNotNull()
        {
            //Arrange
            MathController math = new MathController();

            //Act- Asset
            Assert.IsNotNull(math, "Cann't be null !");
        }
        [TestMethod]
        public void SumNumber_SumPostiveNumberWithNegative_ReturnZero()
        {
            int number1 = 5;
            int number3 = -5;

            //Arrange
            MathController math = new MathController();

            //Act
            int result = math.SumNumber(number1, number3);

            //Asset
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void SubNumber_SubPostiveNumberWithNegative_ReturnNegativeNumber()
        {
            int number1 = 5;
            int number3 = (-5);
            //Arrange
            MathController math2 = new MathController();
            //Act
            int result = math2.SubNumber(number1, number3);
            
            //Asset
            Assert.AreEqual(result, 10);
        }
        [TestMethod]
        public void SubNumber_SubNegativeNumberWithNegative_ReturnZero()
        {
            int number1 = -5;
            int number3 = -5;
            //Arrange
            MathController math = new MathController();
            //Act
            int result = math.SubNumber(number1, number3);

            //Asset
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void DivideNumber_DividPostiveNumberByPositve_ReturnPositiveNumber()
        {
            int number1 = 5;
            int number2 = 5;
            //Arrange
            MathController math = new MathController();

            //Act
            int result = math.DivideNumber(number1, number2);

            //Asset
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void DivideNumber_DividPostiveNumberByNegative_ReturnNegativeNumber()
        {
            int number1 = 5;
            int number3 = -5;
            //Arrange
            MathController math = new MathController();
            //Act
            int result = math.DivideNumber(number1, number3);

            //Asset
            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void DivideNumber_DividPostiveNumberByZero_ThrowException()
        {
            //Arrange
            MathController math3 = new MathController();

            //Act
            try
            {
                  math3.DivideNumber(5,0);
            }
            catch (DivideByZeroException)
            {
                //Asset
                Assert.ThrowsException<DivideByZeroException>(() => "Cann't divide by zero..");

            }
        }
    }
}
