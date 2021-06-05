using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Pets.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Test.ControllerTest
{
    class AdminControllerTest
    {
        [Test]
        public void EditTest_ValidEmailAndPassword()
        {
            AdminController ControllerObj = new AdminController();

            ViewResult viewResultObj = ControllerObj.Edit("taghreed@gmail.com", 112233) as ViewResult;

            Assert.AreEqual("PetsInfo", viewResultObj.ViewName);
        }
        [Test]
        public void EditTest_InvalidPassword()
        {
            AdminController ControllerObj = new AdminController();

            ViewResult viewResultObj = ControllerObj.Edit("taghreed@gmail.com", 11223344) as ViewResult;

            Assert.AreEqual("PetsInfo", viewResultObj.ViewName);
        }
        [Test]
        public void EditTest_InvalidEmail()
        {
            AdminController ControllerObj = new AdminController();

            ViewResult viewResultObj = ControllerObj.Edit("taghreed12@gmail.com", 112233) as ViewResult;

            Assert.AreEqual("PetsInfo", viewResultObj.ViewName);
        }
        [Test]
        public void EditTest_EmptyFields()
        {
            AdminController ControllerObj = new AdminController();

            ViewResult viewResultObj = ControllerObj.Edit("", '\0') as ViewResult;

            Assert.AreEqual("PetsInfo", viewResultObj.ViewName);
        }
    }
}
