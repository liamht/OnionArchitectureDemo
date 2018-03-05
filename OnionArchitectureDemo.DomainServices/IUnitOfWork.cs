using OnionArchitectureDemo.Domain.Entities;
using System;

namespace OnionArchitectureDemo.DomainServices
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Car> Cars { get; }

        IRepository<Sale> Sales { get; }

        void SaveChanges();
    }
}
