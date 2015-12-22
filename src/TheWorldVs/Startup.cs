using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;

namespace TheWorldVs
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            //przydatne przy użyciu IIS do wdrożenia
            //app.UseIISPlatformHandler();

            //potrzebujemy wtedy w project.json
            //"Microsoft.AspNet.IISPlatformHandler": "1.0.0-rc1-final"

            app.Run(async (context) =>
            {
                // wypisze ścieżkę z zapytania; dane wewnątrz stringa - C# 6.0
                await context.Response.WriteAsync($"Hello World!: {context.Request.Path}");
            });
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
