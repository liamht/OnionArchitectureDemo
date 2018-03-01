using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureDemo.DomainServices.Services;
using OnionArchitectureDemo.Data;
using OnionArchitectureDemo.Data.Entities;
using OnionArchitectureDemo.Data.EntityFramework;
using System;
using OnionArchitectureDemo.ApplicationServices;

namespace OnionArchitectureDemo.DependencyInjection
{
    public static class DependencyMapper
    {
        public static void MapApplicationServicesDependencies(this IServiceCollection services)
        {
            services.AddTransient<ICarSaleService, CarSaleService>();
        }

        public static void MapDomainServicesDependencies(this IServiceCollection services)
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
