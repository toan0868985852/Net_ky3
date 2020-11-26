﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using DrinkStores.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace DrinkStores
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<StoreDbContext>(
                opts =>
                {
                    opts.UseSqlServer 
                        (Configuration["ConnectionStrings:DrinkStoresConnection"]);
                }
                );
            services.AddScoped<IStoreRepository, EFStoreRepository>();
            services.AddRazorPages();

            services.AddDistributedMemoryCache();
            services.AddSession();
                
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

            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller=Home}/{action=Index}/{id?}");


                //endpoints.MapControllerRoute(
                //    "pagination", "Drinks/Page{drinkPage}",
                //    new { Controller = "Home", action = "Index" });


                endpoints.MapControllerRoute(
                    "catpage", "{category}/Page{drinkPage:int}",
                    new { Controller = "Home", action = "Index" });
                
                //
                endpoints.MapControllerRoute(
                    "page", "Page{drinkPage:int}",
                    new { Controller = "Home", action = "Index" , drinkPage = 1});

                endpoints.MapControllerRoute(
                  "category", "{category}",
                   new { Controller = "Home", action = "Index", drinkPage = 1 });

                ///chỉ phân trang
                endpoints.MapControllerRoute(
                   "pagination", "Drinks/Page{drinkPage}",
                   new { Controller = "Home", action = "Index", drinkPage = 1 });

                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
            });
            SeedData.EnsurePopulated(app);
        }
    }
}
