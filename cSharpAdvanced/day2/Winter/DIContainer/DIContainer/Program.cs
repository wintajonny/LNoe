using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;


namespace DIContainer
{
    class Program
    {
        static void Main(string[] args)
        {


            using var host = Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(config =>
                {

                })
                .ConfigureServices((context, services )=>
                {
                    var section = context.Configuration.GetSection("GreetingService");
                    services.Configure<GreetingServiceOptions>(section);
                    services.AddTransient<IGreetingService, GreetingService>();
                    services.AddTransient<HomeController>();
                })
                .Build();

            HomeController controller = host.Services.GetRequiredService<HomeController>();
            string result = controller.IndexName("Thomas");
            Console.WriteLine(result);

            HomeController controller2 = host.Services.GetRequiredService<HomeController>();
            Console.WriteLine(controller2.IndexName("Julia"));












            //using var container = CreateDIContainer();
            //HomeController controller = container.GetRequiredService<HomeController>();

            //string result = controller.IndexName("Thomas");
            //Console.WriteLine(result);

            //HomeController controller2 = container.GetRequiredService<HomeController>();
            //Console.WriteLine(controller2.IndexName("Winter"));



        }

        //static ServiceProvider CreateDIContainer()
        //{
        //    ServiceCollection services = new();
        //    services.AddSingleton<IGreetingService, GreetingService>();
        //    services.AddSingleton<HomeController>();
        //    return services.BuildServiceProvider();
        //}
    }
}
