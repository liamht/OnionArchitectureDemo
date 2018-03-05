using OnionArchitectureDemo.Data.EntityFramework.Common;
using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OnionArchitectureDemo.Data.EntityFramework.Sales
{
    public class SalesRepository : Repository<Sale>
    {
        public SalesRepository()
        {
            var today = DateTime.Today;
            StaticData = new List<Sale>()
            {
                new Sale(){ StartDate = today.AddDays(-21), EndDate = today.AddDays(14), MarkDownPercentage = 25 },
                new Sale(){ StartDate = today.AddDays(-7), EndDate = today.AddDays(1), MarkDownPercentage = 25 },
            };
        }
    }
}
