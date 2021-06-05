using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_01_Turki.Controllers;

namespace Project_01_Test
{
    [TestClass]
    public class WeatherControllerTest
    {
        [TestMethod]
        public void TestgetWeatherReturnNull()
        {
            // Arrange
            var controller = new WeatherController();

            //Act
            var result = controller.getWeather("Jeddah");

            //Assert
            Assert.IsNotNull(result);

            //Act
            result = controller.getWeather("Riyadh");

            //Assert
            Assert.IsNotNull(result);

        }
    }
}
