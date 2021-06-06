using System.Threading.Tasks;
using DomainInfo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DomainInfo.Controllers
{
    public class WhoisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Lookup(string name)
        {
            Domain domain = new Domain(name);
            var WhoisLookupTask = domain.WhoisQuery();
            ViewData["record"] = await WhoisLookupTask;
            return View();
        }
    }
}