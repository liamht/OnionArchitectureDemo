using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureDemo.ApplicationServices;
using OnionArchitectureDemo.DomainServices.Entities;
using OnionArchitectureDemo.DomainServices.Services;
using OnionArchitectureDemo.Web.Models;

namespace OnionArchitectureDemo.Web.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private ICarService _carService;
        private ICarSaleService _saleService;

        public SampleDataController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("[action]")]
        public IEnumerable<Car> GetCars()
        {
            return _carService.GetAllCars().AsEnumerable();
        }

        [HttpGet("[action]")]
        public CarDetails GetCarDetails(int carId)
        {
            var car = _carService.GetCarBySalesListingId(carId);
            var preSalePrice = _saleService.GetPreSalePrice(car);

            return new CarDetails(car, preSalePrice);
        }
    }
}
