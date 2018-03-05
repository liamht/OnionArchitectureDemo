using OnionArchitectureDemo.Domain;
using OnionArchitectureDemo.DomainServices.Entities;
using OnionArchitectureDemo.DomainServices.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureDemo.DomainServices.Services
{
    public interface ISaleService
    {
        Sale GetCurrentSale();
    }

    public class SaleService : ISaleService
    {
        private IUnitOfWork _unitOfWork;

        public SaleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Sale GetCurrentSale()
        {
            return _unitOfWork.Sales.Single(c => c.StartDate < DateTime.Now && c.EndDate > DateTime.Now).ToBusinessEntity();
        }
    }
}
