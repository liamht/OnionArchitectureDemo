using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarDetails;
using OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarList;

namespace OnionArchitectureDemo.Web.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private IGetCarListQuery _carListQuery;
        private IGetCarDetailsQuery _carDetailsQuery;

        public CarController(IGetCarListQuery carListQuery, IGetCarDetailsQuery detailsQuery)
        {
            _carListQuery = carListQuery;
            _carDetailsQuery = detailsQuery;
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
    }
}
