using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureDemo.Business.Services;
using OnionArchitectureDemo.Data;
using OnionArchitectureDemo.Data.Entities;
using OnionArchitectureDemo.Data.EntityFramework;
using System;

namespace OnionArchitectureDemo.DependencyInjection
{
    public static class DependencyMapper
    {
        public static void MapBusinessDependencies(this IServiceCollection services)
        {
            services.AddTransient<ICarService, CarService>();
        }

        public static void MapDataDependencies(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Car>, CarRepository>();
            services.AddTransient<IUnitOfWork, RascalDatabaseUnitOfWork>();
        }
    }
}
