using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarDetails;
using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.DomainServices.Common;
using Xunit;

namespace OnionArchitectureDemo.ApplicationServices.Tests.Cars.Queries.GetCarDetails
{
    public class GetCarDetailsQueryTests
    {
        private GetCarDetailsQuery _subject;
        private Mock<IUnitOfWork> _uow;

        private const int SALE_MARKDOWN = 20;
        private readonly Sale _testSale;
        private readonly Car _testCar;

        public GetCarDetailsQueryTests()
        {
            _testCar = new Car() {Make = "Test Make", Model = "Test Model", Price = 10.0};
            _testSale = new Sale() {MarkDownPercentage = SALE_MARKDOWN};

            _uow = new Mock<IUnitOfWork>();

            _uow.Setup(c => c.Cars.GetAll()).Returns(new List<Car>().AsQueryable());
            _uow.Setup(c => c.Cars.Single(It.IsAny<Func<Car, bool>>()))
                 .Returns(_testCar);

            _uow.Setup(c => c.Sales.Single(It.IsAny<Func<Sale, bool>>()))
                .Returns(_testSale);

            _subject = new GetCarDetailsQuery(_uow.Object);
        }

        [Fact]
        public void Execute_GetsSingleCar()
        {
            _subject.Execute(6);

            _uow.Verify(c => c.Cars.Single(It.IsAny<Func<Car, bool>>()), Times.Once);
        }

        [Fact]
        public void Execute_GetsSingleSale()
        {
            _subject.Execute(6);

            _uow.Verify(c => c.Sales.Single(It.IsAny<Func<Sale, bool>>()), Times.Once);
        }

        [Fact]
        public void Execute_SetsPresalePriceAsPriceBeforeSalesReduction()
        {
            var expectedPrice = _testCar.Price / (100 - SALE_MARKDOWN) * 100;
            var result = _subject.Execute(6);

            Assert.Equal(expectedPrice, result.PreSalePrice);
        }
    }
}
