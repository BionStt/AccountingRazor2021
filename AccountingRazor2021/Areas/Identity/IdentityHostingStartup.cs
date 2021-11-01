using System;
using AccountingRazor2021.Data;
using AccountingRazor2021.Domain;
using AccountingRazor2021.Persistence.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AccountingRazor2021.Areas.Identity.IdentityHostingStartup))]
namespace AccountingRazor2021.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }

        //public void Configure(IWebHostBuilder builder)
        //{


        //    builder.ConfigureServices((context, services) => {
        //        services.AddDbContext<AccountingDbContext>(options =>
        //            options.UseSqlServer(
        //                context.Configuration.GetConnectionString("DefaultConnection")));

        //        services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
        //            .AddEntityFrameworkStores<AccountingDbContext>();
        //    });
        //}
    }
}