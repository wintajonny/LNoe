using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace HostSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.Configure<GreetingServiceOptions>(options => options.From = "Christian");
                    services.AddTransient<IGreetingService, GreetingService>();
                    services.AddTransient<HomeController>();
                })
                .Build();

            HomeController controller = host.Services.GetRequiredService<HomeController>();

            string result = controller.Index("Matthias");
            Console.WriteLine(result);

            HomeController controller1 = host.Services.GetRequiredService<HomeController>();
            Console.WriteLine(controller1.Index("Katharina"));

        }

    }
}
