using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingRazor2021.Persistence.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MediatR;
using AccountingRazor2021.Persistence.Dapper;
using AccountingRazor2021.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using NToastNotify;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Http;
using AccountingRazor2021.Models;
using AccountingRazor2021.Services;
using System.Globalization;
using System.Reflection;
using Microsoft.Extensions.Logging;

namespace AccountingRazor2021
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _cultures = Configuration.GetSection("Cultures").Get<string[]>().Select(p => new CultureInfo(p)).ToList();
        }

        public IConfiguration Configuration { get; }

        private readonly IList<CultureInfo> _cultures;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            services.AddLocalization(options => options.ResourcesPath = "Resources");

            //services.AddDbContext<AccountingDbContext>(options => options.UseSqlServer(connectionString));
            
            services.AddDbContext<AccountingDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                    .EnableSensitiveDataLogging()
                    .LogTo(Console.WriteLine, LogLevel.Information));
            
            services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                 .AddEntityFrameworkStores<AccountingDbContext>()
                 .AddDefaultUI()
         .AddDefaultTokenProviders();

       
            services.AddMvc(o =>
            {
                //Add Authentication to all Controllers by default.
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                o.Filters.Add(new AuthorizeFilter(policy));
            }).AddNToastNotifyNoty(new NotyOptions
            {
                Layout = "bottomRight",
                ProgressBar = true,
                Timeout = 5000,
                Theme = "metroui"
            }); ;

            services.AddTransient<IDbConnectionFactory>(x => new DapperConnectionFactory(connectionString));

            //services.AddMediatR(typeof(Startup));
            // Register MediatR
          
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            //var typeFinder = new AppTypeFinder();
            //var assemblies = typeFinder.GetAssemblies();
            //services.AddMediatR(assemblies.ToArray());

            services.AddRazorPages().AddViewLocalization().AddDataAnnotationsLocalization();

            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.Configure<SMTPSettings>(Configuration.GetSection("SMTPSettings"));
            services.Configure<ApplicationSettings>(Configuration.GetSection("ApplicationSettings"));
         
            services.AddScoped<IEmailService, EmailService>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new("id-ID"),
                SupportedCultures = _cultures,
                SupportedUICultures = _cultures
            });

            app.UseNToastNotify();
          
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
