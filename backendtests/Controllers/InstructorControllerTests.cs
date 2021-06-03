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
    public class InstructorControllerTests
    {
        private static WebApplicationFactory<Startup> _factory;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            // Web app simulator
            _factory = new WebApplicationFactory<Startup>();
        }

        [TestMethod]
        public async Task ShouldReturnSuccessResponse()
        {
            var client = _factory.CreateClient();
            var json = (dynamic)new JsonObject();
            json.id = 2;
            json.name = "Younes Alturkey";
            json.speciality = "Lawn Mowing";
            json.rating = 5;
            json.email = "younes.alturkey@tuwaiq.edu.sa";
            json.phone = "0538654514";
            json.bootcampId = 6;

            var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/Instructor", content);

            //Check if we can successfully post an instructor (insert into the db)
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        }


        [TestMethod]
        public async Task ShouldReturnNoContent()
        {
            var client = _factory.CreateClient();
  
            var response = await client.DeleteAsync("/api/Instructor/1017456");

            //Check if we can successfully delete an instructor (drop from the db)
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
        }


        [TestMethod]
        public async Task ShouldReturnOkResponse()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/api/Instructor");

            //Check if we can retrieve all instructors from the db
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _factory.Dispose();
        }
    }
}
