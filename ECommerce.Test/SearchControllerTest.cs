using ECommerce_ASPNET.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Test
{
    [TestFixture]
    class SearchControllerTest
    {
        private SearchController _searchController;

        [SetUp]
        public void Setup()
        {
            _searchController = new SearchController();
            _searchController.ControllerContext.HttpContext = new DefaultHttpContext();
        }

        [Test]
        public void Index_RequestWithoutErrorMessage_ReturnsEmptyString()
        {
            ViewResult viewResult = _searchController.Index() as ViewResult;

            Assert.AreEqual("", viewResult.ViewData["ErrorMessage"]);
        }

        [Test]
        public void Index_RequestEmptyErrorMessage_ReturnsEmptyString()
        {
            _searchController.HttpContext.Request.QueryString = new QueryString("?err_msg=");

            ViewResult viewResult = _searchController.Index() as ViewResult;

            Assert.AreEqual("", viewResult.ViewData["ErrorMessage"]);
        }

        [Test]
        public void Index_RequestWithErrorMessage_ReturnsSameProvidedErrorMessage()
        {
            string errorMessage = "This is an error message";

            _searchController.HttpContext.Request.QueryString = new QueryString($"?err_msg={errorMessage}");

            ViewResult viewResult = _searchController.Index() as ViewResult;

            Assert.AreEqual(errorMessage, viewResult.ViewData["ErrorMessage"]);
        }

        [Test]
        public void Index_ViewNameIsIndex_ReturnsTrue()
        {
            ViewResult viewResult = _searchController.Index() as ViewResult;
            Assert.IsTrue(viewResult.ViewName == "Index" || viewResult.ViewName == null);
        }
    }
}
