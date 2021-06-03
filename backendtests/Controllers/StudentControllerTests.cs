using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using backend;
using System.Net;

namespace backendtests.Controllers
{
    [TestClass]
    public class StudentControllerTests
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

            var response = await client.GetAsync("/api/student");

            //Check if the expected status is returned
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public async Task ShouldReturnJSONResponse()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/api/student");

            Assert.AreEqual("application/json; charset=utf-8", response.Content.Headers.ContentType?.ToString());
        }

        [TestMethod]
        public async Task ShouldReturnExpectedStudent()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync("/api/student");

            //Check if we're getting the expected JSON
            response = await client.GetAsync("/api/student/1943222");
            var json = await response.Content.ReadAsStringAsync();
            var expectedJSON = "{\"id\":1943222,\"name\":\"Younes Alturkey\",\"major\":\"Lawn Mower\",\"grade\":1,\"email\":\"younes.alturkey@tuwaiq.edu.sa\",\"phone\":\"0538654514\"}";
            Assert.AreEqual(expectedJSON, json);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _factory.Dispose();
        }
    }
}
