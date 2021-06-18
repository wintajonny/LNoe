using HelloMVCSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVCSample.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RemoteServiceOptions _RemoteOptions;

        public HomeController(ILogger<HomeController> logger, IOptions<RemoteServiceOptions> options)
        {
            _logger = logger;
            _RemoteOptions = options.Value;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index Called!");
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
    }
}
