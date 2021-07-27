using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Client - wait for service");
            Console.ReadLine();

            using var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    string booksUri = context.Configuration.GetSection("BooksService")["BooksUri"];
                    services.AddHttpClient<Runner>(client =>
                    {
                        client.BaseAddress = new Uri(booksUri);
                    });
                })
                .Build();

            var runner = host.Services.GetRequiredService<Runner>();
            await runner.ShowBooksAsync();

            Console.ReadLine();
        }
    }
}
