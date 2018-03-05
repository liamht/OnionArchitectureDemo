using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OnionArchitectureDemo.Data.EntityFramework
{
    /// <summary>
    /// NOTE: this should all be using EF with a real database. Usually in a shared dataacess project.
    /// </summary>
    public class SalesRepository : IRepository<Sale>
    {
        public void Add(Sale entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Sale entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Sale> GetAll()
        {
            var today = DateTime.Today;

            //todo: Get From actual Database
            return new List<Sale>()
            {
                new Sale(){ StartDate = today.AddDays(-21), EndDate = today.AddDays(14), MarkDownPercentage = 25 },
                new Sale(){ StartDate = today.AddDays(-7), EndDate = today.AddDays(1), MarkDownPercentage = 25 },
            }.AsQueryable();
        }

        public Sale Single(Func<Sale, bool> function)
        {
            return GetAll().SingleOrDefault(function);
        }
    }
}
