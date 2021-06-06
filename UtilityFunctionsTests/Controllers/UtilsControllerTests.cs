using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using NUnit.Framework;
using UtilityFunctions.Controllers;

namespace UtilityFunctionsTests.Controllers
{
    public class UtilsControllerTests
    {
        [Test]
        public void GetRelativeTime_ValidUnixTimeAsInput_ReturnsValidRelativeTime()
        {
            UtilsController controllerObj = new UtilsController();

            var reltime = controllerObj.GetRelativePostDate((int)DateTimeOffset.Now.ToUnixTimeSeconds());

            Assert.That(reltime, Does.Contain("seconds ago"));
        }

        [Test]
        public void GetRelativeTime_ReturnsEmptyStringOnInvalidUnixTimeFormat()
        {
            UtilsController controllerObj = new UtilsController();

            var reltime = controllerObj.GetRelativePostDate(1);

            Assert.AreEqual("", reltime);
        }

        [Test]
        public void GetWebsiteName_ReturnsWebsiteNameOnValidUrlInput()
        {
            UtilsController controllerObj = new UtilsController();

            var websiteName = controllerObj.GetShortenedWebsite("https://twitter.com/Twitter/status/1398341197047939073");
        
            Assert.AreEqual("twitter.com", websiteName);
        }

        [Test]
        public void GetWebsiteName_ReturnsEmptyStringOnInvalidUrlInput()
        {
            UtilsController controllerObj = new UtilsController();

            var websiteName =
                controllerObj.GetShortenedWebsite("kittens");

            Assert.AreEqual("", websiteName);
        }


        [Test]
        public void GetFaviconUrl_ValidUrlAsInput_ReturnsResponseContainingIcon()
        {
            UtilsController controllerObj = new UtilsController();

            var response =
                controllerObj.GetFaviconUrl("https://www.bbc.com/news/");
            
            Assert.AreEqual(new MediaTypeHeaderValue("image/png"), response.Result.Content.Headers.ContentType);
        }

        [Test]
        public void GetFaviconUrl_ExceptionThrownOnInvalidUrl()
        {
            UtilsController controllerObj = new UtilsController();
            Assert.ThrowsAsync<HttpRequestException>( () => controllerObj.GetFaviconUrl("////"));
        }

    }
}