using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UtilityFunctions.Controllers
{
    public class UtilsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RelativeDate(long unixTime)
        {
            var relativeTime = GetRelativePostDate(unixTime);
            ViewData["RelativeTime"] = relativeTime;
            ViewData["UnixTime"] = unixTime;
            return View();
        }

        public IActionResult WebsiteName(string url)
        {
            var websiteName = GetShortenedWebsite(url);
            ViewData["WebsiteName"] = websiteName;
            ViewData["Url"] = url;
            return View();
        }

        // this method converts the post date in unix time format to relative time
        public string GetRelativePostDate(long unixTime)
        {
            var date = DateTimeOffset.FromUnixTimeSeconds(unixTime).LocalDateTime;
            var timeSpan = DateTime.Now.Subtract(date);

            if (timeSpan <= TimeSpan.FromSeconds(60))
            {
                return timeSpan.Seconds + " seconds ago";
            }

            if (timeSpan <= TimeSpan.FromMinutes(60))
            {
                return timeSpan.Minutes > 1
                    ? timeSpan.Minutes + " minutes ago"
                    : "a minute ago";
            }

            if (timeSpan <= TimeSpan.FromHours(24))
            {
                return timeSpan.Hours > 1
                    ? timeSpan.Hours + " hours ago"
                    : "an hour ago";
            }

            if (timeSpan <= TimeSpan.FromDays(30))
            {
                return timeSpan.Days > 1 ? timeSpan.Days + " days ago" : "yesterday";
            }

            return "";
        }

        // this method uses a google service to return the favicon of a given website
        public async Task<HttpResponseMessage> GetFaviconUrl(string url)
        {
            HttpClient client = new HttpClient();
            var requestUrl = $"https://www.google.com/s2/favicons?domain={url}";

                HttpResponseMessage response = await client.GetAsync(requestUrl);
                response.EnsureSuccessStatusCode();
                if (response.Content.Headers.ContentType != null)
                    return response;
            
            client.Dispose();
            return null;
        }

        // this method return the website name from the full url
        public string GetShortenedWebsite(string absoluteUrl)
        {
            if (Uri.IsWellFormedUriString(absoluteUrl, UriKind.Absolute))
            {
                return new Uri(absoluteUrl).Host.Replace("www.", "");
            }
            return "";
        }
    }
}