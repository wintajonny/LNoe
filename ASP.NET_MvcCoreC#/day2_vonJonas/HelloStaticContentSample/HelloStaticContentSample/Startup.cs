using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloStaticContentSample
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<ICustomerDb()
            services.AddSingleton<ICustomerDb, CustomerDb>(); //einmal angelegt immer wieder genutzt
            //services.AddScoped();    // Mittelding. 
            services.AddTransient<BusinessLogic1>(); //angelegt und wieder vergessen
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    BusinessLogic1 logic = context.RequestServices.GetRequiredService<BusinessLogic1>();
                    var actual = logic.ComputePriceForCustomer(1,100);
                    await context.Response.WriteAsync($"Kunde 1, 100€ = {actual:0.00}€");
                });
            });
        }
    }
}
