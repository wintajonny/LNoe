using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Polly;
using Polly.Extensions.Http;

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
                    //services.AddHttpClient("myclient", client =>
                    //{
                    //    client.BaseAddress = new Uri("https://localhost:5001");
                    //}).AddTypedClient<Runner>();

                    services.AddHttpClient<Runner>(client =>
                    {
                        client.BaseAddress = new Uri("https://localhost:5001");
                    });
                    // services.AddTransient<Runner>();
                    services.AddHttpClient<F1Client>(client =>
                    {
                        client.BaseAddress = new Uri("https://www.cninnovation1.com");

                    }).AddTransientHttpErrorPolicy(policy => policy.WaitAndRetryAsync(new[] { TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(2), TimeSpan.FromSeconds(3) }));  // network failures, HTTP 5xx, HTTP 408


                }).Build();

            Console.WriteLine("Client - wait for service to run");
            Console.ReadLine();

            var f1 = host.Services.GetRequiredService<F1Client>();
            await f1.ShowRacersAsync();

            //var runner = host.Services.GetRequiredService<Runner>();
            //for (int i = 0; i < 1000; i++)
            //{
            //    await runner.GetBooksAsync();
            //}


            Console.ReadLine();
        }
    }
}
