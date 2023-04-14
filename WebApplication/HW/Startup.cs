using HW.Entities.DAL;
using HW.Interfaces;
using HW.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;
using System;
using System.Runtime.InteropServices;

namespace HW
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {            
            services.AddSwaggerGen();
            services.AddControllers();

            services.AddTransient<IManagementCars, ManagementCarsService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IManagementCars cars)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/GetCarAge", async context =>
                {
                    await context.Response.WriteAsync($"{cars.GetCarAge()}");
                });
                endpoints.MapGet("/GetCarEngine", async context =>
                {
                    await context.Response.WriteAsync($"{cars.GetCarEngine()}");
                });
                endpoints.MapGet("/GetCarName", async context =>
                {
                    await context.Response.WriteAsync($"{cars.GetCarName()}");
                });
                endpoints.MapControllers();
            });
        }
    }
}

