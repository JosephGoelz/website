﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace JosephGoelz
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
                routes.MapRoute("Default",
                    "{controller=Home}/{action=Index}/{id?}"));

            app.UseFileServer();
            /*
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello World! \n");
                await next();
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World Again!");
            });
            */
        }
    }
}
