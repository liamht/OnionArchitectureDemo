using OnionArchitectureDemo.Data.EntityFramework.Cars;
using OnionArchitectureDemo.Data.EntityFramework.Sales;
using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.DomainServices;
using System;

namespace OnionArchitectureDemo.Data.EntityFramework
{
    public class RascalDatabaseUnitOfWork : IUnitOfWork
    {
        private IRepository<Car> _cars;
        public IRepository<Car> Cars
        {
            get
            {
                if (_cars == null)
                {
                    _cars = new CarRepository();
                }
                return _cars;
            }
        }

        private IRepository<Sale> _sales;
        public IRepository<Sale> Sales
        {
            get
            {
                if (_sales == null)
                {
                    _sales = new SalesRepository();
                }
                return _sales;
            }
        }

        public void Dispose()
        {
            // todo: When using a database, dispose the context object
            return;
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
