using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    class HomeController
    {
        private readonly IHelloService _helloService;
        private readonly ILogger _logger;
        private readonly string _val1;
        public HomeController(IHelloService helloService,
            IHostEnvironment hostEnvironment,
            ILogger<HomeController> logger, 
            IConfiguration configuration)
        {
            _helloService = helloService;
            _logger = logger;
            _val1 = configuration["mykey1"] ?? "no value";
            Console.WriteLine(hostEnvironment.EnvironmentName);
        }
        public string Index(string name)
        {
            Console.WriteLine($"val1: {_val1}");
            string result = _helloService.Greet(name);
            return result.ToUpper();
        }

        public void SimulateError(string error)
        {
            _logger.LogError(error);
        }
    }
}
