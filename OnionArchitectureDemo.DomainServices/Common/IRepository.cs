using System;
using System.Linq;

namespace OnionArchitectureDemo.DomainServices.Common
{
    public interface IRepository<T>
    {
        void Add(T entity);

        void Delete(T entity);

        IQueryable<T> GetAll();

        T Single(Func<T, bool> function);
    }
}
