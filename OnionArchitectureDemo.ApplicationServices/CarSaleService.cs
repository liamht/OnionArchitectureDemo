using OnionArchitectureDemo.DomainServices.Entities;
using OnionArchitectureDemo.DomainServices.Services;
using System;

namespace OnionArchitectureDemo.ApplicationServices
{
    public interface ICarSaleService
    {
        double GetPreSalePrice(Car c);
    }

    public class CarSaleService : ICarSaleService
    {
        private ISaleService _service;

        public CarSaleService(ISaleService service)
        {
            _service = service;
        }

        public double GetPreSalePrice(Car car)
        {
            var currentSale = _service.GetCurrentSale();
            if (currentSale == null)
            {
                return car.Price;
            }

            return car.Price / (100 - currentSale.MarkDownPercentage) * 100;
        }
    }
}
