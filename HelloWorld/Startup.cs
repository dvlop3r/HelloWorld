using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using HelloWorld.controller;
using HelloWorld.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace HelloWorld
{
    public class Startup
    {
        IConfiguration config;
        public Startup(IConfiguration configuration)
        {
            this.config = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<FormattingService>();
            services.AddTransient<Post>();

            services.AddTransient<FeatureToggle>(x => new FeatureToggle
            {
                DeveloperException = config.GetValue<bool>("sarwan:EnableDeveloperException")
            });

            services.AddDbContext<EmployeeDB>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("EmployeeDBContext"));
            });
            services.AddDbContext<PostContext>(options => 
            {
                options.UseSqlServer(config.GetConnectionString("PostContext"));
            });
            services.AddDbContext<IdentityContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("IdentityDBContext"));
            });
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<IdentityContext>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,FeatureToggle featureToggle)
        {
            app.UseExceptionHandler("/error.html");

            if (featureToggle.DeveloperException)   
            {
                app.UseDeveloperExceptionPage();
            }


            //app.UseFileServer();
            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc((route) =>
            {
                route.MapRoute("default", "{controller=home}/{action=index}/{id?}");
            });



            /*app.Run(async (context) =>
            {
                if (context.Request.Path.Value.Contains("error"))
                    throw new Exception("some kind of error just occured!");
            });*/
        }
    }
}
