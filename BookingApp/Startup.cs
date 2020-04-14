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
using Westwind.AspNetCore.LiveReload;
using Microsoft.EntityFrameworkCore;
using BookingApp.DataAccess;
using BookingApp.ApplicationLogic.Abstractions;
using BookingApp.ApplicationLogic.Services;

namespace BookingApp
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
            //services.AddLiveReload();

            services.AddControllersWithViews();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders",
                      builder =>
                      {
                          builder.AllowAnyOrigin()
                                 .AllowAnyHeader()
                                 .AllowAnyMethod();
                      });
            });

            services.AddDbContext<BookingAppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("connectionString")));
            services.AddScoped<IAdministratorRepository, AdministratorRepository>();
            services.AddScoped<IBarbershopRepository, BarbershopRepository>();
            services.AddScoped<CinemaService>();
            services.AddScoped<RestaurantService>();
            services.AddScoped<BarbershopService>();
            services.AddScoped<ContactService>();
            services.AddScoped<BarbershopReservationService>();
            services.AddScoped<IBarbershopReservationRepository, BarbershopReservationRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseLiveReload();
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

            app.UseCors(
                "AllowAllHeaders"
            );

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
