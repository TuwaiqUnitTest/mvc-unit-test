using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;
using MathProject.Controllers;

namespace MathProjectTest.Controller
{
    [TestClass]
    public class MathControllerTest
    {
        [TestMethod]
        public void Addition_AddsTwoIntegers()
        {
            //Arange
            MathController MathC = new MathController();

            //Act
            int result1 = MathC.Addition(20, 50);
            int result2 = MathC.Addition(40, 60);

            //Assert
            Assert.AreEqual(70, result1);
            Assert.AreEqual(100, result2);
        }
        public void Subtraction_SubtractsTwoIntegers()
        {
            //Arange
            MathController MathC = new MathController();

            //Act
            int result1 = MathC.Subtraction(100, 50);
            int result2 = MathC.Subtraction(70, 20);

            //Assert
            Assert.AreEqual(50, result1);
            Assert.AreEqual(50, result2);
        }
        public void Multiplication_MultipliesTwoIntegers()
        {
            //Arange
            MathController MathC = new MathController();

            //Act
            int result1 = MathC.Multiplication(6, 10);
            int result2 = MathC.Multiplication(7, 7);

            //Assert
            Assert.AreEqual(60, result1);
            Assert.AreEqual(49, result2);
        }
        public void Division_DividesTwoIntegers()
        {
            //Arange
            MathController MathC = new MathController();

            //Act
            int result1 = MathC.Division(18, 6);
            int result2 = MathC.Division(36, 6);

            //Assert
            Assert.AreEqual(6, result1);
            Assert.AreEqual(6, result2);
        }
    }
}
