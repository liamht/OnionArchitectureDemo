using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureDemo.Domain;
using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.Data.EntityFramework;
using System;
using OnionArchitectureDemo.ApplicationServices;
using OnionArchitectureDemo.DomainServices;
using OnionArchitectureDemo.Data.EntityFramework.Cars;

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
        }

        public static void MapDataDependencies(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Car>, CarRepository>();
            services.AddTransient<IUnitOfWork, RascalDatabaseUnitOfWork>();
        }
    }
}
