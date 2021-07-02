using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Lab1EFCore
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                var dbConnection = context.Configuration.GetConnectionString("BooksConnection");
                services.AddDbContext<BooksContext>(options =>
                {
                    options.UseSqlServer(dbConnection);
                });
                services.AddScoped<Runner>();
            }).Build();

            var runner = host.Services.GetRequiredService<Runner>();

            runner.ClearDb();

            await runner.CreateDataBaseAsync();

            Book b1 = new(title: "Monty Maulwurf", publisher: "WinterVerlagGmbH");
            Book b2 = new(title: "Bernhard Bienchen", publisher: "WinterVerlagGmbH", id:0);
            Book b3 = new(title: "Zorro Zebra", publisher: "WinterVerlagGmbH");

            await runner.WriteData(b1);

            runner.Query();

            await runner.WriteData(b2);
            await runner.WriteData(b3);

            runner.Query();
        }
    }
}
