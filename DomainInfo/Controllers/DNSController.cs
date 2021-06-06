using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DomainInfo.Models;

namespace DomainInfo.Controllers
{
    public class DNSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Lookup(string name, DNSRecordType type)
        {
            Domain domain = new Domain(name);
            var DNSLookupTask = domain.DNSQuery(type);
            ViewData["records"] = await DNSLookupTask;
            return View();
        }
    }
}