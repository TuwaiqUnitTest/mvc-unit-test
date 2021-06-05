using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoronaVirusCases.Controllers;
using CoronaVirusCases.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;


namespace TestProject1.Controllers
{
    class ApiControllerTest
    {
        [OneTimeSetUp]
        public void Setup()
        {
            for (int i = 1; i < 14; i++)
            {
                Random r = new Random();
                RegionModel newRegion = new RegionModel
                {
                    Id = "SA-" + i,
                    TotalConfirmed = r.Next(50000, 90000),
                    NewConfirmed = r.Next(100, 700),
                    TotalRecovered = r.Next(10000, 50000),
                    NewRecovered = r.Next(100, 700),
                    TotalDeaths = r.Next(10000, 50000),
                    NewDeaths = r.Next(100, 700),
                    CountryCode = "SA"
                };

                ListOfCases.SaudiCases.Add(newRegion);
            }
        }

        [Test]
        public void Countries_ListOfCases()
        {
            // Arrange
            ApiController controller = new();

            // Act
            JsonResult JsonObj = (JsonResult) controller.Countries();

            // Assert
            Assert.AreEqual(ListOfCases.Countries, JsonObj.Value);
        }

        [Test]
        public void Region_SA_ListOfCases()
        {
            // Arrange
            ApiController controller = new();

            // Act
            JsonResult JsonObj = (JsonResult) controller.Region("SA");

            // Assert
            Assert.AreEqual(ListOfCases.SaudiCases, JsonObj.Value);
        }

        [Test]
        public void Region_USA_CountryNotAvailable()
        {
            // Arrange
            ApiController controller = new();

            // Act
            JsonResult JsonObj = (JsonResult)controller.Region("USA");

            // Assert
            Assert.AreEqual("country not available", JsonObj.Value);
        }
    }
}
