using OnionArchitectureDemo.Data.Static.Cars;
using OnionArchitectureDemo.Data.Static.Sales;
using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.DomainServices.Common;
using System;

namespace OnionArchitectureDemo.Data.Static
{
    public class StaticDataUnitOfWork : IUnitOfWork
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
