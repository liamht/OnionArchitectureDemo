using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureDemo.ApplicationServices.Cars.Commands;
using OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarDetails;
using OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarList;
using OnionArchitectureDemo.Web.Cars.Services;
using OnionArchitectureDemo.Web.Cars.ViewModels;

namespace OnionArchitectureDemo.Web.Cars
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private IGetCarListQuery _carListQuery;
        private IGetCarDetailsQuery _carDetailsQuery;
        private ICreateCarViewModelFactory _carCreationFactory;
        private ICreateCarCommand _createCommand;

        public CarController(
            IGetCarListQuery carListQuery, 
            IGetCarDetailsQuery detailsQuery, 
            ICreateCarViewModelFactory carCreationFactory, 
            ICreateCarCommand createCommand)
        {
            _carListQuery = carListQuery;
            _carDetailsQuery = detailsQuery;
            _carCreationFactory = carCreationFactory;
            _createCommand = createCommand;
        }

        [HttpGet("[action]")]
        public IEnumerable<CarModel> GetAll()
        {
            return _carListQuery.Execute();
        }

        [HttpGet("[action]")]
        public CarDetailsModel GetDetails(int carId)
        {
            return _carDetailsQuery.Execute(carId);
        }

        [HttpGet("[action]")]
        public CreateCarViewModel Create(int carId)
        {
            return _carCreationFactory.Create();
        }

        [HttpPost("[action]")]
        public void Create([FromBody]CreateCarModel model)
        {
            _createCommand.Execute(model);
        }
    }
}
