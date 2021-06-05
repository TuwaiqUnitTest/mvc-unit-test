using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.Net.Http;
using Newtonsoft.Json.Linq;

using CoronaVirusCases.Models;

namespace CoronaVirusCases.Controllers
{
    public class ApiController : Controller
    {
        public JsonResult Countries()
        {
            return Json(ListOfCases.Countries);
        }

        public JsonResult Region(string country)
        {
            if(country != "SA")
            {
                return Json("country not available");
            }

            return Json(ListOfCases.SaudiCases);
        }

        public string FillData()
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri("https://api.covid19api.com/summary");

                var response = client.GetAsync(uri);

                response.Wait();

                if (response.Result.IsSuccessStatusCode)
                {
                    var responseRead = response.Result.Content.ReadAsStringAsync();

                    JObject objResult = JObject.Parse(responseRead.Result);

                    foreach (var country in objResult["Countries"])
                    {
                        CountryModel newCountry = new CountryModel
                        {
                            TotalConfirmed = (int)country["TotalConfirmed"],
                            NewConfirmed = (int)country["NewConfirmed"],
                            TotalRecovered = (int)country["TotalRecovered"],
                            NewRecovered = (int)country["NewRecovered"],
                            TotalDeaths = (int)country["TotalDeaths"],
                            NewDeaths = (int)country["NewDeaths"],
                            CountryCode = (string)country["CountryCode"]
                        };

                        ListOfCases.Countries.Add(newCountry);
                    }

                    var global = objResult["Global"];
                    ListOfCases.GlobalCases = new GlobalModel
                    {
                        TotalConfirmed = (int)global["TotalConfirmed"],
                        NewConfirmed = (int)global["NewConfirmed"],
                        TotalRecovered = (int)global["TotalRecovered"],
                        NewRecovered = (int)global["NewRecovered"],
                        TotalDeaths = (int)global["TotalDeaths"],
                        NewDeaths = (int)global["NewDeaths"],
                        CreatedAt = (DateTime) global["Date"]
                    };

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

                    return "ok";
                }

                return "not ok";
            }

        }
    }

    public class ListOfCases
    {
        public static List<CountryModel> Countries = new List<CountryModel>();
        public static List<RegionModel> SaudiCases = new List<RegionModel>();
        public static GlobalModel GlobalCases;
    }
}
