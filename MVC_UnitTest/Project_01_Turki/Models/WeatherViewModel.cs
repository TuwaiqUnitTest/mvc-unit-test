using System;
namespace Project_01_Turki.Models
{
    public class WeatherViewModel
    {
        public Location location { get; set; }
        public CurrentWeather current { get; set; }
       
    }

    public class Location
    {
        public string name { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public DateTime localtime { get; set; }
    }

    public class CurrentWeather
    {
        public WeatherCondition condition { get; set; }
        public double temp_c { get; set; }
       
    }

    public class WeatherCondition
    {
        public string text { get; set; }
        public string icon { get; set; }
    }
}
