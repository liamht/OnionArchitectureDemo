using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarDetails;
using OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarList;

namespace OnionArchitectureDemo.Web.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private IGetCarListQuery _carListQuery;
        private IGetCarDetailsQuery _carDetailsQuery;

        public SampleDataController(IGetCarListQuery carListQuery, IGetCarDetailsQuery detailsQuery)
        {
            _carListQuery = carListQuery;
            _carDetailsQuery = detailsQuery;
        }

        [HttpGet("[action]")]
        public IEnumerable<CarModel> GetCars()
        {
            return _carListQuery.Execute();
        }

        [HttpGet("[action]")]
        public CarDetailsModel GetCarDetails(int carId)
        {
            return _carDetailsQuery.Execute(carId);
        }
    }
}
