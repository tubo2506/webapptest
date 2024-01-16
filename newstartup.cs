using System.Buffers;
using System.Runtime.Serialization;
using System.Net.Http.Headers;
using System.Threading;
using System.Net.Mime;
using System.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
public class MyStartup{
    public void ConfigureServices( IServiceCollection services)
    {
            services.AddRazorPages().AddRazorPagesOptions(options => {
                options.RootDirectory = "/Pages";
            });
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }
        app.UseStaticFiles();
        app.UseRouting();
        app.UseEndpoints(endpoints => {
            endpoints.MapRazorPages();
            endpoints.MapGet("/", async (context) => {
                     await context.Response.WriteAsync("Trang Chu");
                });

            endpoints.MapGet("/login", async (context) => {
                     await context.Response.WriteAsync("Ban hay dang nhap!");
                });
        
            endpoints.MapGet("/hotline", async (context) => {
                     await context.Response.WriteAsync("Ban hay lien he tt: 0202-933-81");
                });
            app.UseStatusCodePages();
            
        });
    }
}