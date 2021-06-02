using System;

namespace HostSample
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeController controller = new(new GreetingService());
            string result = controller.Index("Stephanie");
            Console.WriteLine(result);
        }
    }
}
