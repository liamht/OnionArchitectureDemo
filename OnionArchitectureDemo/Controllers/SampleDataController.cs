using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureDemo.DomainServices.Entities;
using OnionArchitectureDemo.DomainServices.Services;

namespace OnionArchitectureDemo.Web.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        ICarService _carService;

        public SampleDataController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("[action]")]
        public IEnumerable<Car> GetCars()
        {
            return _carService.GetAllCars().AsEnumerable();
        }
    }
}
