using System;
using Moq;
using OnionArchitectureDemo.Data.Static.Cars;
using OnionArchitectureDemo.Data.Static.Common;
using OnionArchitectureDemo.Data.Static.Sales;
using OnionArchitectureDemo.Domain.Entities;
using Xunit;

namespace OnionArchitectureDemo.Data.Static.Tests
{
    public class StaticDataUnitOfWorkTests
    {
        private StaticDataUnitOfWork _subject;

        public StaticDataUnitOfWorkTests()
        {
            _subject = new StaticDataUnitOfWork();
        }

        [Fact]
        public void Cars_ReturnsCarRepository()
        {
            var carType = _subject.Cars.GetType();
            var repositoryType = typeof(CarRepository);

            Assert.Equal(carType, repositoryType);
        }


        [Fact]
        public void Sales_ReturnsSaleRepository()
        {
            var carType = _subject.Sales.GetType();
            var repositoryType = typeof(SalesRepository);

            Assert.Equal(carType, repositoryType);
        }
    }
}
