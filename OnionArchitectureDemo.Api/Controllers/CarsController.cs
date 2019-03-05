using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureDemo.ApplicationServices.Cars.Commands;
using OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarDetails;
using OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarList;

namespace OnionArchitectureDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IGetCarListQuery _getListQuery;
        private readonly IGetCarDetailsQuery _detailsQuery;
        private readonly ICreateCarCommand _createCommand;
                
        public CarsController(IGetCarListQuery getQuery, IGetCarDetailsQuery detailsQuery,
            ICreateCarCommand createCommand)
        {
            _getListQuery = getQuery;
            _detailsQuery = detailsQuery;
            _createCommand = createCommand;
        }

        [HttpGet]
        [Route("Get")]
        public IList<CarModel> Get()
        {
            return _getListQuery.Execute();
        }

        [HttpGet]
        [Route("Details/{id}")]
        public CarDetailsModel Details(int id)
        {
            return _detailsQuery.Execute(id);
        }

        [HttpPost]
        [Route("Create")]
        public void Create(CreateCarModel model)
        {
            _createCommand.Execute(model);
        }
    }
}
