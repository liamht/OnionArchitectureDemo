using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.DomainServices.Common;
using System.Collections.Generic;
using System.Linq;

namespace OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarList
{
    public class GetCarListQuery : IGetCarListQuery
    {
        private readonly IUnitOfWork _uow;

        public GetCarListQuery(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IList<CarModel> Execute()
        {
            return _uow.Cars.GetAll()
                .Select(c => ConvertToCarModel(c))
                .ToList();
        }

        private CarModel ConvertToCarModel(Car c)
        {
            return new CarModel()
            {
                Make = c.Make,
                Model = c.Model,
                Price = c.Price
            };
        }
    }
}
