using System.Linq;
using Xunit;
using System;
using DomainInfo.Controllers;
using DomainInfo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DomainInfo.Test
{
    public class UnitTest1
    {
        [Fact]
        public void DNSIndexControllerWhenVisitedWithNoInputs()
        {
            // Arrange
            var controller = new DNSController();

            // Act
            var result = controller.Index();

            // Assert
            var view = Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public async void DNSLookupWithValidDomainNameAndRecordType()
        {
            // Arrange
            var controller = new DNSController();

            // Act
            var result = await controller.Lookup("0xmaneea.com", Models.DNSRecordType.A);

            // Assert
            var view = Assert.IsType<ViewResult>(result);
            Assert.True(view.ViewData.ContainsKey("records"));
            var records = Assert.IsType<DNSRecords>(view.ViewData["records"]);
            Assert.NotNull(records.Records);
            Assert.Equal(1, records.Records.Length);
            Assert.Equal("134.209.30.255", records.Records[0].Content);
        }

        [Fact]
        public async void DNSLookupWithInvalidDomainNameAndRecordType()
        {
            // Arrange
            var controller = new DNSController();

            // Act
            var result = await controller.Lookup("!does-not-exist!.com", Models.DNSRecordType.A);

            // Assert
            var view = Assert.IsType<ViewResult>(result);
            Assert.True(view.ViewData.ContainsKey("records"));
            var records = Assert.IsType<DNSRecords>(view.ViewData["records"]);
            Assert.Null(records.Records);
        }
    }
}
