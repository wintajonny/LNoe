using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System.Threading.Tasks;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        var connectionString = context.Configuration.GetConnectionString("BooksConnection");
        services.AddDbContext<BooksContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
        services.AddDbContext<BankContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
        services.AddDbContext<MenusContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
        services.AddScoped<BooksRunner>();
        services.AddScoped<BankRunner>();
        services.AddScoped<MenusRunner>();
    })
    .Build();

using (var scope = host.Services.CreateScope())
{
    var booksRunner = scope.ServiceProvider.GetRequiredService<BooksRunner>();

    await booksRunner.CreateTheDatabaseAsync();
    for (int i = 0; i < 100; i++)
    {
        await booksRunner.GetBooksForAuthorAsync();
        await Task.Delay(200);
    }


    var bankRunner = scope.ServiceProvider.GetRequiredService<BankRunner>();
    await bankRunner.CreateTheDatabaseAsync();
    await bankRunner.AddSampleDataAsync();
    await bankRunner.QuerySampleAsync();

    var menusRunner = scope.ServiceProvider.GetRequiredService<MenusRunner>();
    await menusRunner.CreateTheDatabaseAsync();
}

