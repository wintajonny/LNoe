using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    class HelloService : IHelloService
    {
        private readonly ILogger _logger;
        public HelloService(ILogger<HelloService> logger)
        {
            _logger = logger;
        }

        public string Greet(string name)
        {
            _logger.LogTrace("Greet invoked");
            return $"Hello, {name}";
        }
    }
}
