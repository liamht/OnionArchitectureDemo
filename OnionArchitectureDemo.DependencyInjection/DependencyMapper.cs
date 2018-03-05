using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.Data.Static;
using OnionArchitectureDemo.Data.Static.Cars;
using OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarDetails;
using OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarList;
using OnionArchitectureDemo.DomainServices.Common;
using OnionArchitectureDemo.ApplicationServices.Cars.Commands;
using OnionArchitectureDemo.ApplicationServices.Cars.Commands.Factory;

namespace OnionArchitectureDemo.DependencyInjection
{
    public static class DependencyMapper
    {
        public static void MapApplicationServicesDependencies(this IServiceCollection services)
        {
            services.AddTransient<IGetCarDetailsQuery, GetCarDetailsQuery>();
            services.AddTransient<IGetCarListQuery, GetCarListQuery>();
            services.AddTransient<ICreateCarCommand, CreateCarCommand>();
            services.AddTransient<ICarFactory, CarFactory>();
        }

        public static void MapDomainServicesDependencies(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Car>, CarRepository>();
            services.AddTransient<IUnitOfWork, StaticDataUnitOfWork>();
        }
    }
}
