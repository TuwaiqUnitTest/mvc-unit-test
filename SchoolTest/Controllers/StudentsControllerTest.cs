using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolTest
{
    [TestClass]
    public class StudentsControllerTest
    {
        [TestMethod]
        public void IndexTest_WithNoParam()
        {
            var controller = new StudentsController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
        [TestMethod]
        public void IndexTest_WithTrueParam()
        {
            var controller = new StudentsController();
            var result = controller.Index(true) as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
        [TestMethod]
        public void IndexTest_WithFalseParam()
        {
            var controller = new StudentsController();
            var result = controller.Index(false) as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
        [TestMethod]
        public void SearchTest()
        {
            var controller = new StudentsController();
            var result = controller.Search("Abdulmajeed") as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
        [TestMethod]
        public void SearchTest_WithEmptyString()
        {
            var controller = new StudentsController();
            var result = controller.Search("") as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void DetailsTest()
        {
            var controller = new StudentsController();
            var result = controller.Details(1) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);
        }

    }
}
