using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using backend;
using System.Net;
using RestSharp;
using System.Net.Http;

namespace backendtests.Controllers
{
    [TestClass]
    public class TeamControllerTests
    {
        private static WebApplicationFactory<Startup> _factory;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _factory = new WebApplicationFactory<Startup>();
        }

        [TestMethod]
        public async Task ShouldReturnOkResponse()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/api/Team");

            //Check if the expected status is returned
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public async Task ShouldReturnNoContent()
        {
            var client = _factory.CreateClient();
            var json = (dynamic)new JsonObject();
            json.id = 14;
            json.name = "Change Team Name";
            json.instructorId = 1017456;
            json.formDate = "0001-01-01T00:00:00";

            var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
            var response = await client.PutAsync("/api/Team/14", content);
            Console.WriteLine(response.StatusCode);

            //Check if we can sucessfully update team's info according to business logic
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _factory.Dispose();
        }
    }
}
