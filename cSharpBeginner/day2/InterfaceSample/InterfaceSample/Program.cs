using System;

namespace InterfaceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeController controller = new(new GreetingService());
            var result = controller.Index("Stephanie");
            Console.WriteLine(result);
        }
    }
}
