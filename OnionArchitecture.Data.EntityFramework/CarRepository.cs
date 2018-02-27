using OnionArchitectureDemo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnionArchitectureDemo.Data.EntityFramework
{
    /// <summary>
    /// NOTE: this should all be using EF with a real database. Usually in a shared dataacess project.
    /// </summary>
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
                new Car(){ HasSpareWheel = true, Make = "Vauxhall", Model = "Corsa" },
                new Car(){ HasSpareWheel = false, Make = "BMW", Model = "1 Series (116i) Diesel" }
            }.AsQueryable();
        }
    }
}
