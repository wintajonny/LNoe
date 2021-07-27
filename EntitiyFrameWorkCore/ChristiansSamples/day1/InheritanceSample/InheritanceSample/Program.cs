using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace InheritanceSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    var connectionString = context.Configuration.GetConnectionString("BankConnection");
                    services.AddDbContext<BankContext>(options =>
                    {
                        options.UseSqlServer(connectionString);
                    });
                    services.AddScoped<Runner>();
                }).Build();

            var runner = host.Services.GetRequiredService<Runner>();
            await runner.CreateDatabaseAsync();
            await runner.QueryAsync();

        }
    }
}
