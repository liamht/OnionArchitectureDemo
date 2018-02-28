using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OnionArchitectureDemo.Data
{
    public interface IRepository<T>
    {
        void Add(T entity);

        void Delete(T entity);

        IQueryable<T> GetAll();

        T Single(Func<T, bool> function);
    }
}
