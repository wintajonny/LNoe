using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostSample
{
    public class GreetingService : IGreetingService
    {
        public GreetingService()
        {
            Console.WriteLine("GreetingService ctor");
        }

        public string Greet(string name) => $"Hello, {name}";
    }
}
