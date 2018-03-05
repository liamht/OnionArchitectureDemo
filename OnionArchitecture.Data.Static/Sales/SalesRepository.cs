using OnionArchitectureDemo.Data.Static.Common;
using OnionArchitectureDemo.Domain.Entities;
using System;
using System.Collections.Generic;

namespace OnionArchitectureDemo.Data.Static.Sales
{
    public class SalesRepository : Repository<Sale>
    {
        public SalesRepository()
        {
            var today = DateTime.Today;
            StaticData = new List<Sale>()
            {
                new Sale(){ StartDate = today.AddDays(-21), EndDate = today.AddDays(-14), MarkDownPercentage = 25 },
                new Sale(){ StartDate = today.AddDays(-7), EndDate = today.AddDays(1), MarkDownPercentage = 25 },
            };
        }
    }
}
