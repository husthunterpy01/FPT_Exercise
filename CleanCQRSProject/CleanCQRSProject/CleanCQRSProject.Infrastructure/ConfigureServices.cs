﻿using CleanCQRSProject.Domain.Repository;
using CleanCQRSProject.Infrastructure.Data;
using CleanCQRSProject.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCQRSProject.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BlogDbContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("BlogdbContext") ??
                    throw new InvalidOperationException("Connection string 'BlogDbContext Not found'"));
            });
            services.AddTransient<IBlogRepository, BlogRepository>();
            return services;
        }
    }
}
