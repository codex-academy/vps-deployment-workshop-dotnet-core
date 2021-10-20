using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using vps_deployment_workshop_dotnet_core.Models;

namespace vps_deployment_workshop_dotnet_core.Controllers
{
    public class HomeController : Controller
    {

        private static int counter = 0;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Counter = counter;
            return View();
        }

        public IActionResult Increase()
        {
            counter++;
            return new RedirectResult("/Home");
        }

        public IActionResult Decrease()
        {
            if (counter > 0) {
                counter--;
            }
            return new RedirectResult("/Home");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
