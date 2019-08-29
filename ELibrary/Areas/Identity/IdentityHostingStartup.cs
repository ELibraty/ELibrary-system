﻿using System;
using ELibrary.Data;
using ELibrary.Data.Models;
using ELibrary.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ELibrary.Areas.Identity.IdentityHostingStartup))]
namespace ELibrary.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ELibraryDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ELibraryContextConnection")));

                services.AddDefaultIdentity<User>()
                    .AddEntityFrameworkStores<ELibraryDbContext>();
            });
        }
    }
}