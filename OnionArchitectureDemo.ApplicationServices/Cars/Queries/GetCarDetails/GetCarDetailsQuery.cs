using OnionArchitectureDemo.ApplicationServices.Common;
using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.DomainServices;
using System;

namespace OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarDetails
{
    public class GetCarDetailsQuery
    {
        private readonly IUnitOfWork _uow;

        public GetCarDetailsQuery(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public CarDetailsModel Execute(int carListingId)
        {
            var today = DateTime.Today;

            var car = _uow.Cars.Single(c => c.SalesListingId == carListingId);

            var sale = _uow.Sales.Single(c => c.StartDate <= today && c.EndDate > DateTime.Today);

            return GenerateCarDetailsModel(car, sale);
        }

        private CarDetailsModel GenerateCarDetailsModel(Car car, Sale sale)
        {
            var currentPriceMarkDown = (100 - sale.MarkDownPercentage);
            var presalePrice = car.Price / currentPriceMarkDown * 100;

            return new CarDetailsModel
            {
                Make = car.Make,
                Model = car.Model,
                Price = car.Price,
                PreSalePrice = presalePrice
            };
        }
    }
}
