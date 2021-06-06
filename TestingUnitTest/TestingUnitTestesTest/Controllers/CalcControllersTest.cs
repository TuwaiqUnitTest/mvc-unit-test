using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;
using TestingUnitTest.Controllers;

namespace TestingUnitTestesTest.Controllers
{
   [TestFixture]
    class CalcControllersTest
    {
        [Test]
        public void Test_Sum_Two_Positive()
        {
            //Arrange
            CalcController calc = new CalcController();
            //Act 
            int total = calc.sum(1, 2);
            //Assert
            Assert.AreEqual(3, total);
        }
        [Test]
        public void Test_Sum_Two_Nigativ()
        {
            //Arrange
            CalcController calc2 = new CalcController();
            //Act 
            int total2 = calc2.sum(-1, -2);
            //Assert
            Assert.AreEqual(-3, total2);
        }
        [Test]
        public void Test_Sum_Positive_Nigativ()
        {
            //Arrange
            CalcController calc3 = new CalcController();
            //Act 
            int total3 = calc3.sum(1, -2);
            //Assert
            Assert.AreEqual(-1, total3);
        }
        [Test]
        public void Test_Sub_Two_Nigativ()
        {
            //Arrange
            CalcController calc4 = new CalcController();
            //Act 
            int total4 = calc4.sub(-10, -3);
            //Assert
            Assert.AreEqual(-7, total4);
        }
        [Test]
        public void Test_Sub_Positive_Nigativ()
        {
            //Arrange
            CalcController calc5 = new CalcController();
            //Act 
            float total5 = calc5.sub(15, -3);
            //Assert
            Assert.AreEqual(18, total5);
        }
        [Test]
        public void Test_Sub_Two_Positive()
        {
            //Arrange
            CalcController calc6 = new CalcController();
            //Act 
            int total6 = calc6.sub(15, 3);
            //Assert
            Assert.AreEqual(12, total6);
        }
       
    }
}
