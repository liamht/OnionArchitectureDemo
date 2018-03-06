using OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.DomainServices.Common;
using Xunit;

namespace OnionArchitectureDemo.ApplicationServices.Tests.Cars.Queries.GetCarList
{
    public class GetCarListQueryTests
    {
        private GetCarListQuery _subject;
        private Mock<IUnitOfWork> _uow;

        private List<Car> _carList;

        public GetCarListQueryTests()
        {
            _carList = new List<Car>()
            {
                new Car(){ Make = "Test Make", Model = "Test Model"},
                new Car(){ Make = "Test Make", Model = "Test Model"}
            };

            _uow = new Mock<IUnitOfWork>();
            _uow.Setup(c => c.Cars.GetAll()).Returns(_carList.AsQueryable());

            _subject = new GetCarListQuery(_uow.Object);
        }

        public void Execute_ReturnsAllCars()
        {
            var result = _subject.Execute();

            Assert.Equal(result.Count, _carList.Count);
        }
        public void Execute_SetsCarNameAsMakeAndModel()
        {
            var expected = _carList.First().Make + " " + _carList.First().Model;
            var result = _subject.Execute();

            Assert.Equal(expected, result.First().CarName);
        }
    }
}
