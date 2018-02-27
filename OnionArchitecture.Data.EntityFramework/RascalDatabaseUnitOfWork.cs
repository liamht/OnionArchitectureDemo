using OnionArchitectureDemo.Data.Entities;
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
