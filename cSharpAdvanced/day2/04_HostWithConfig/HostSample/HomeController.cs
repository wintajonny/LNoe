using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostSample
{
    public class HomeController
    {
        private readonly IGreetingService _greetingService;
        private readonly IConfiguration _configuration;
        public HomeController(IGreetingService greetingService, IConfiguration configuration)
        {
            _greetingService = greetingService;
            _configuration = configuration;
            Console.WriteLine("HomeController ctor");
        }
        public string Index(string name)
        {
            string value = _configuration["MyKey1"];
            Console.WriteLine($"value for MyKey1: {value}");


            var booksConnection = _configuration.GetConnectionString("BooksConnection");
            Console.WriteLine(booksConnection);

            string result = _greetingService.Greet(name);
            return result.ToUpper();
        }
    }
}
