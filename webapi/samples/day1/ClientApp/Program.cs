using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddTransient<Runner>();
                }).Build();

            Console.WriteLine("Client - wait for service to run");
            Console.ReadLine();

            var runner = host.Services.GetRequiredService<Runner>();
            await runner.GetBooksAsync();

            Console.ReadLine();
        }
    }
}
