using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.Controllers;

namespace TestingProjectTest.Controllers
{

    [TestFixture]
    class CalculatoresControllerTest
    {
        [Test]
        public void Index_HomeView_AreEqual()
        {
            //Arrange
            CalculatoresController ControllerObj = new CalculatoresController();

            //Act
            ViewResult viewResultObj = ControllerObj.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Home", viewResultObj.ViewName);

        }

        [Test]
        public void SalaryWithdraw_LessAmount_AreEqual()
        {
            //Arrange
            CalculatoresController ControllerObj = new CalculatoresController();

            //Act
            int salary = ControllerObj.SalaryWithdraw(200,100);

            //Assert
            Assert.AreEqual(100, salary);
        }
        [Test]
        public void SalaryWithdraw_SameAmount_AreEqual()
        {
            //Arrange
            CalculatoresController ControllerObj = new CalculatoresController();

            //Act
            int salary = ControllerObj.SalaryWithdraw(200, 200);

            //Assert
            Assert.AreEqual(0, salary);
        }
        [Test]
        public void SalaryWithdraw_BiggerAmount_ThrowException()
        {
            //Arrange
            CalculatoresController ControllerObj = new CalculatoresController();

            //Act
            var ex = Assert.Throws<Exception>(() => ControllerObj.SalaryWithdraw(200, 400));
            //Assert
            Assert.That(ex.Message, Is.EqualTo("funds are less than amount"));
        }
    }
}
