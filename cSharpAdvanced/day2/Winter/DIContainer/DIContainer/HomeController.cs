using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIContainer
{
    public class HomeController
    {
        private readonly IGreetingService _greetingService;
        private readonly IConfiguration _configuration;

        public HomeController(IGreetingService greetingService, IConfiguration configuration)
        {
            _greetingService = greetingService;
            _configuration = configuration;
            Console.WriteLine("HomeController constructor");
        }

        public string IndexName(string name)
        {
            Console.WriteLine(_configuration["MyKey1"]);



            string result = _greetingService.Greet(name);
            return result.ToUpper();
        }
    }
}
