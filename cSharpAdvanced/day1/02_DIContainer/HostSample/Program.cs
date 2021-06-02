using Microsoft.Extensions.DependencyInjection;
using System;

namespace HostSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = CreateDIContainer();
            HomeController controller = container.GetRequiredService<HomeController>();

            string result = controller.Index("Matthias");
            Console.WriteLine(result);

            HomeController controller1 = container.GetRequiredService<HomeController>();
            Console.WriteLine(controller1.Index("Katharina"));

        }

        static IServiceProvider CreateDIContainer()
        {
            ServiceCollection services = new();
            services.AddTransient<IGreetingService, GreetingService>();
            services.AddTransient<HomeController>();
            return services.BuildServiceProvider();
        }
    }
}
