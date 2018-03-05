using OnionArchitectureDemo.Data.EntityFramework.Common;
using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OnionArchitectureDemo.Data.EntityFramework.Cars
{
    public class CarRepository : Repository<Car>
    {
        public CarRepository()
        {
            StaticData = new List<Car>()
            {
                new Car(){ HasSpareWheel = true, Make = "Vauxhall", Model = "Corsa", Price = 6985, SalesListingId = 948883},
                new Car(){ HasSpareWheel = false, Make = "BMW", Model = "1 Series (116i) Diesel", Price = 10995, SalesListingId = 989938 }
            };
        }
    }
}
