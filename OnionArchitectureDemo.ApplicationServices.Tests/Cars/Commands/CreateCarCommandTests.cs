using OnionArchitectureDemo.ApplicationServices.Cars.Commands;
using System;
using Moq;
using OnionArchitectureDemo.ApplicationServices.Cars.Commands.Factory;
using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.DomainServices.Common;
using Xunit;

namespace OnionArchitectureDemo.ApplicationServices.Tests.Cars.Commands
{
    public class CreateCarCommandTests
    {
        private CreateCarCommand _subject;
        private Mock<ICarFactory> _factory;
        private Mock<IUnitOfWork> _uow;

        public CreateCarCommandTests()
        {
            _factory = new Mock<ICarFactory>();
            _factory.Setup(c => c.Create(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<double>()))
                .Returns(new Car());

            _uow = new Mock<IUnitOfWork>();
            _uow.Setup(c => c.Cars.Add(It.IsAny<Car>()));
            _uow.Setup(c => c.SaveChanges());

            _subject = new CreateCarCommand(_factory.Object, _uow.Object);
        }

        [Fact]
        public void Execute_GeneratesDomainObjectFromFactory()
        {
            var modelToAdd = new CreateCarModel();
            _subject.Execute(modelToAdd);

            _factory.Verify(c => c.Create(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<double>()), Times.Once);
        }

        [Fact]
        public void Execute_AddsItemToUnitOfWork()
        {
            var modelToAdd = new CreateCarModel();
            _subject.Execute(modelToAdd);

            _uow.Verify(c => c.Cars.Add(It.IsAny<Car>()), Times.Once());
        }

        [Fact]
        public void Execute_SavesItemIntoUnitOfWork()
        {
            var modelToAdd = new CreateCarModel();
            _subject.Execute(modelToAdd);

            _uow.Verify(c => c.SaveChanges());
        }
    }
}
