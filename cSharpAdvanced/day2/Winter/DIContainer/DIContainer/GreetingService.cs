using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIContainer
{

    public record GreetingServiceOptions
    {
        public string From { get; set; }
    }

    public class GreetingService : IGreetingService
    {
        private readonly ILogger _logger;
        private string _from;
        public GreetingService(ILogger<GreetingService> logger, IOptions<GreetingServiceOptions> options)
        {
            _logger = logger;
            _from = options.Value.From ?? "stringNotFound";
            _logger.LogDebug("GreetingService constructor");
            //Console.WriteLine("GreetingService constructor");
        }


        public string Greet(string name) => $"Hello, {name} from {_from}";
    }
}
