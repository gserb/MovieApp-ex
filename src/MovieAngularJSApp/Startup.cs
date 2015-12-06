using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Hosting;
using Microsoft.Data.Entity;
using MovieAngularJSApp.Models;
using Microsoft.Framework.Configuration;

namespace MovieAngularJSApp
{
    public class Startup
    {
        public IConfigurationBuilder Configuration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            // Setup configuration sources
            Configuration = new ConfigurationBuilder()
                .AddIniFile("config.json")
                .AddEnvironmentVariables();
        }

        


        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // Register Entity Framework
            services.ConfigureOptions(Configuration).AddEntityFramework()
                .AddDbContext<MoviesAppContext>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
