using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using Microsoft.Extensions.Logging;

namespace HostSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using var host = Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logging =>
                {
                    logging.AddFilter(level => true);
                })
                .ConfigureAppConfiguration(config =>
                {
                })
                .ConfigureServices((context, services) =>
                {
                    var section = context.Configuration.GetSection("GreetingService");

                    // services.Configure<GreetingServiceOptions>(options => options.From = "Christian");
                    services.Configure<GreetingServiceOptions>(section);
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
