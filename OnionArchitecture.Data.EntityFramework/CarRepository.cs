using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OnionArchitectureDemo.Data.EntityFramework
{
    public class CarRepository : IRepository<Car>
    {
        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Car> GetAll()
        {
            //todo: Get From actual Database
            return new List<Car>()
            {
                new Car(){ HasSpareWheel = true, Make = "Vauxhall", Model = "Corsa", Price = 6985, SalesListingId = 948883},
                new Car(){ HasSpareWheel = false, Make = "BMW", Model = "1 Series (116i) Diesel", Price = 10995, SalesListingId = 989938 }
            }.AsQueryable();
        }

        public Car Single(Func<Car, bool> function)
        {
            return GetAll().SingleOrDefault(function);
        }
    }
}
