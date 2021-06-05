using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Project_01_Turki.Models;
namespace Project_01_Turki.Controllers
{
    public class WeatherController : Controller
    {

        List<string> cities = new List<string>() { new("Riyadh"), new("Jeddah"), new("Makkah"), new("al hada"), new("Al Lith"), new("Tabuk"), new("Al ula"), new("Yanbu"), new("Abha"), new("Jizan"), new("khamis mushait"), new("Dammam"), new("Al khobar")};
        List<WeatherViewModel> listOfCities = new List<WeatherViewModel>();


        public async Task<IActionResult> Index()
        {
            WeatherViewModel c = new WeatherViewModel();
            //city = getWeather();
            //ViewBag.city = city;

            foreach (var city in cities)
            {
                c = null;
                c = await getWeather(city);
                listOfCities.Add(c);
            }

            ViewBag.cities = listOfCities;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<WeatherViewModel> getWeather(string city)
        {
            WeatherViewModel c = new WeatherViewModel();
            

            //Api key: 7b0a51e5b8fb499fbdc181307212705
            using (var httpClient = new HttpClient())
            {
                var url = new Uri("http://api.weatherapi.com/v1/current.json?key=7b0a51e5b8fb499fbdc181307212705&q=" + city);
                var apiResponse = await httpClient.GetAsync(url);
                var result = await apiResponse.Content.ReadAsStringAsync();
                dynamic receivedObject = JObject.Parse(result);
                c = receivedObject.ToObject<WeatherViewModel>();
            }

            return c;
        }
    }
}
