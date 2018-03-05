using OnionArchitectureDemo.DomainServices.Entities;
using OnionArchitectureDemo.DomainServices.Extensions;
using OnionArchitectureDemo.Domain;
using System.Linq;

namespace OnionArchitectureDemo.DomainServices.Services
{
    public interface ICarService
    {
        IQueryable<Car> GetAllCars();

        Car GetCarBySalesListingId(int listingId);
    }

    public class CarService : ICarService
    {
        private IUnitOfWork _uow;

        public CarService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public IQueryable<Car> GetAllCars()
        {
            return _uow.Cars.GetAll().Select(c => c.ToBusinessEntity());
        }

        public Car GetCarBySalesListingId(int listingId)
        {
            return _uow.Cars.Single(c => c.SalesListingId == listingId).ToBusinessEntity();
        }
    }
}
