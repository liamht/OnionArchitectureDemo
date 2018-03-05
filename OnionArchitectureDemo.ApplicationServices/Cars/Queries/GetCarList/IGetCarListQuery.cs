using System.Collections.Generic;

namespace OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarList
{
    public interface IGetCarListQuery
    {
        IList<CarModel> Execute();
    }
}