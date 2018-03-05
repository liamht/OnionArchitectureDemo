using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureDemo.DomainServices.Services;
using OnionArchitectureDemo.Domain;
using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.Data.EntityFramework;
using System;
using OnionArchitectureDemo.ApplicationServices;
using OnionArchitectureDemo.DomainServices;

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
