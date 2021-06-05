using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoronaVirusCases.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace TestProject1.Controllers
{
    class RegionsControllerTest
    {
        [Test]
        public void Index_SA_View()
        {
            // Arrange
            RegionsController controller = new();

            // Act
            ViewResult viewObj = (ViewResult) controller.Index("SA");

            // Assert
            Assert.AreEqual("Index", viewObj.ViewName);
        }

        [Test]
        public void Index_GR_CountryNotAvailable()
        {
            // Arrange
            RegionsController controller = new();

            // Act
            ContentResult contentObj = (ContentResult) controller.Index("GR");

            // Assert
            Assert.AreEqual("country not available", contentObj.Content);
        }
    }
}
