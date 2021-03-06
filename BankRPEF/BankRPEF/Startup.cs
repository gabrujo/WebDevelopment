using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using BankRPEF.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BankRPEF.Utils;
using Microsoft.AspNetCore.Http;
using BankRPEF.Cache;
using BankRPEF.ServicesBusiness;
using BankRPSQL.ServicesBusiness;
using Microsoft.Extensions.Caching.Distributed;

namespace BankRPEF
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
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(
             Configuration.GetConnectionString("MYBANK")));
            services.AddDefaultIdentity<IdentityUser>(options =>
           options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddRazorPages();
            services.AddDistributedMemoryCache(); // for session storage
            services.AddSession(opts =>
            {
                opts.Cookie.Name = ".AMSite.SessionID";
                opts.IdleTimeout = TimeSpan.FromMinutes(5); // 5 minute session timeout
            });
            //--------------------------------------
            services.AddHttpContextAccessor();
            services.AddDbContext<Models.MYBANKContext>(options =>
            options.UseSqlServer(
            Configuration.GetConnectionString("MYBANK")));
            services.AddScoped<IBusinessBanking, BusinessBanking>();
            services.AddScoped<IBusinessAuthentication, BusinessAuthentication>();
            services.AddSingleton<CacheAbstraction>();

            services.AddDistributedMemoryCache();
            // Redis also implements the IDistributedCache so code for
            // storing and retrieving from Redis is same as the SQL Server cache
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = "localhost";
                options.InstanceName = "SampleInstance";
            });


        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            
            RedisCacheHelper.IDISTCACHE = redisService;
            // obtain the CacheAbstraction service and store a reference
            // to it in the CacheAbstractionHelper.CABS so that
            // Repository or some other class can access it
            var appServices = app.ApplicationServices;
            var cacheService = appServices.GetRequiredService<CacheAbstraction>();
            CacheAbstractionHelper.CABS = cacheService;

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSession();

            HttpContextHelper.Configure(app.ApplicationServices.GetRequiredService < IHttpContextAccessor > ());


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            var redisService = (IDistributedCache)appServices.GetRequiredService(typeof(IDistributedCache));
        }
    }
}
