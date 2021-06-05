using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Project01_ASP.NET_MVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_ASP.NET_MVCTest.Controllers
{
    [TestFixture]
    class CalcControllerTest
    {

        [Test]
        public void SumTwoNumbers()
        {
            CalcController controller = new CalcController();

            ViewResult viewObj = (ViewResult)controller.Sum(5,2);

            Assert.AreEqual(7, viewObj.ViewData["res"]);
        }

        [Test]
        public void subTwoNumber()
        {
            CalcController controller = new CalcController();

            ViewResult viewObj = (ViewResult)controller.Sub(7, 5);

            Assert.AreEqual(2, viewObj.ViewData["res"]);
        }

        [Test]
        public void Mul()
        {
            CalcController controller = new CalcController();

            ViewResult viewObj = (ViewResult)controller.Mul(5, 5);

            Assert.AreEqual(25, viewObj.ViewData["res"]);
        }

        [Test]
        public void DivByZero()
        {
            CalcController controller = new CalcController();

            ViewResult viewObj = (ViewResult)controller.Div(5,0);

            Assert.AreEqual("ERROR", viewObj.ViewData["res"]);
        }

    }
}
