using OnionArchitectureDemo.ApplicationServices.Cars;
using OnionArchitectureDemo.DomainServices;
using System;

namespace OnionArchitectureDemo.ApplicationServices
{
    public interface ICarSaleService
    {
        double GetPreSalePrice(CarModel c);
    }

    public class CarSaleService : ICarSaleService
    {
        private IUnitOfWork _uow;

        public CarSaleService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public double GetPreSalePrice(CarModel car)
        {
            var today = DateTime.Today;
            var currentSale = _uow.Sales.Single(c => c.StartDate <= today && c.EndDate > today);
            if (currentSale == null)
            {
                return car.Price;
            }

            return car.Price / (100 - currentSale.MarkDownPercentage) * 100;
        }
    }
}
