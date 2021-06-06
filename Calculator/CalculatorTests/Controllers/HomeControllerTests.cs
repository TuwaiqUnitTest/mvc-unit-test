using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        HomeController h = new HomeController();
         
        [TestMethod()]
        public void sub_TwoPositeveNumbers()
        {
            float num1 = 3;
            float num2 = 6;
            float correctResult = -3;

            float result = h.sub(num1,num2); 

            Assert.AreEqual(correctResult,result,0.001);
        }
        [TestMethod()]
        public void sub_TwoNegativeNumbers()
        {
            float num1 = -16;
            float num2 = -3;
            float correctResult = -13;

            float result = h.sub(num1, num2);

            Assert.AreEqual(correctResult, result, 0.001);
        }

        [TestMethod()]
        public void sub_num1Negative()
        {
            float num1 = -3;
            float num2 = 6;
            float correctResult =-9;

            float result = h.sub(num1, num2);

            Assert.AreEqual(correctResult, result, 0.001);
        }
        [TestMethod()]
        public void sum_TwoPositeveNumbers()
        {
            float num1 = 3;
            float num2 = 6;
            float correctResult = 9;

            float result = h.sum(num1, num2);

            Assert.AreEqual(correctResult, result, 0.001);
        }
        [TestMethod()]
        public void sum_TwoNegativeNumbers()
        {
            float num1 = -3;
            float num2 = -6;
            float correctResult = -9;

            float result = h.sum(num1, num2);

            Assert.AreEqual(correctResult, result, 0.001);
        }
        [TestMethod()]
        public void sum_num1Negative()
        {
            float num1 = -3;
            float num2 = 6;
            float correctResult = 3;

            float result = h.sum(num1, num2);

            Assert.AreEqual(correctResult, result, 0.001);
        }
        [TestMethod()]
        public void div_TwoNegativeNumbers()
        {
            float num1 = -3;
            float num2 = -6;
            float correctResult = 0.5f;

            float result = h.div(num1, num2);

            Assert.AreEqual(correctResult, result, 0.001);
        }
        [TestMethod()]
        public void div_TwoPositeveNumbers()
        {
            float num1 = 3;
            float num2 = 6;
            float correctResult = 0.5f;

            float result = h.div(num1, num2);

            Assert.AreEqual(correctResult, result, 0.001);
        }
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void div_DivideByZero()
        {
            float num1 = 3;
            float num2 = 0;

            float result = h.div(num1, num2);
        
            Assert.ThrowsException<DivideByZeroException>(()=> h.div(num1,num2));
        }
    }
}