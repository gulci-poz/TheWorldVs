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


            // jeśli usuniemy app.Run(), to aplikacja pobierze index.html z wwwroot (IISExpress i web)
            app.UseDefaultFiles();
            app.UseStaticFiles();
            // ważna jest kolejność wywołania tych metod, to łańcuch wywołań middleware

            // nie tylko dodajemy namespace przez using, ale także zależność w project.json
            // zarówno dla IISExpress, jak i dla web trzeba w przeglądarce dodać do ścieżki index.html
            // (chyba, że użyjemy app.UseDefaultFiles()), framework MVC powinien załatwić sprawę

            /*
            app.Run(async (context) =>
            {
                // w context mamy np. ścieżkę request albo query string, i inne

                // wypisze ścieżkę z zapytania; dane wewnątrz stringa - C# 6.0
                //await context.Response.WriteAsync($"Hello, World: {context.Request.Path}");

                var html = @"<!DOCTYPE html>
                    <html>
                        <head>
                        </head>
                        <body>
                            <h2>The World</h2>
                        </body>
                    </html>";

                await context.Response.WriteAsync(html);
            });
            */
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
