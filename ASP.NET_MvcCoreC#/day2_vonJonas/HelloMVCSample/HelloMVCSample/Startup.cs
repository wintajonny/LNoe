using HelloMVCSample.CommentStorage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVCSample
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Version 1
            Console.WriteLine(Configuration["Comments:MostRecent"]);
            //Version 2
            Console.WriteLine(Configuration.GetSection("Comments")["MostRecent"]);
            //Verison3
            CommentOption opt = new CommentOption();
            Configuration.GetSection("Comments").Bind(opt);
            Console.WriteLine(opt.MostRecent);

            //TODO: services.AddOptions<CommentOption>("Comments");
            //Version 4

            //services.AddOptions<CommentOption>().Configure<ILogger<CommentOption>>(
            //    (o, l) => { l.LogInformation("Dynamic setting");
            //        o.MostRecent = 10; });
            services.Configure<CommentOption>(Configuration.GetSection("Comments"));

            services.Configure<RemoteServiceOptions>(Configuration.GetSection("RemoteService"));


            services.AddControllersWithViews();
            services.AddSingleton<ICommentStore, CommentStore>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                //name: "adminArea",
                //pattern: "Admin/{controller=Home}/{action=Index}/{id?}",
                //defaults: new { area = "Admin" }
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
