using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Sample1;

using System;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddScoped<IHelloService, HelloService>();
        services.AddScoped<HomeController>();
    })
    .ConfigureLogging(logging =>
    {
        logging.AddFilter(loglevel => true);
    })
    .ConfigureAppConfiguration(config =>
    {

    })
    .Build();

using var scope = host.Services.CreateScope();
var controller = scope.ServiceProvider.GetRequiredService<HomeController>();

controller.SimulateError("some error occurred");
var result = controller.Index("Stephanie");
Console.WriteLine(result);

