using OnionArchitectureDemo.Domain.Entities;
using System;

namespace OnionArchitectureDemo.DomainServices.Common
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Car> Cars { get; }

        IRepository<Sale> Sales { get; }

        void SaveChanges();
    }
}
