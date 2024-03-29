using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HelloMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //this configuration object is for reading in runtime configuration
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
            // register for dependency injection
            //set up middleware in here
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //plug in middle ware to the request life cycle
            //and at the bottom, configure our routes
            if (env.IsDevelopment())
            {
                //in Dev Environment, print the exception page
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
                //in this lambda expression here, we can map as many routes as we want, right now one route is mapped

                //like a try catch (the way is runs)
                endpoints.MapControllerRoute(
                     name: "privacy",
                    pattern: "Privacy",//matched against url
                    defaults: new { Controller = "Home", Action = "Privacy" }
                    //that is "anonymous type" - object without class
                    //"web deveopler" way of tinking, just stuff the data in there
                    // with no compile-time checking

               );
                //This is endpoint routing anohter type is attribute routing
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
