using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AMT_Asset__Mgt_Tool_.Models;
using System.Text.Encodings.Web;

namespace AMT_Asset__Mgt_Tool_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        public IActionResult amt(string name, string dep, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;
            ViewData["dep"] = dep;

            return View();
        }
        

        public string Welcome(string name, int numTimes = 1)
        {

            
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            //return "This is the Welcome action method...";
        }
    }
}
