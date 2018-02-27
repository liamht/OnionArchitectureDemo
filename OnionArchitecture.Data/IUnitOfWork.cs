using OnionArchitectureDemo.Data.Entities;
using System;

namespace OnionArchitectureDemo.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Car> Cars { get; }

        void SaveChanges();
    }
}
