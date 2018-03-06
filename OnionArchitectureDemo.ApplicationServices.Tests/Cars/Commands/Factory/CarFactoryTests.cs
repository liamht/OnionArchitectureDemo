using System;
using System.Collections.Generic;
using System.Text;
using OnionArchitectureDemo.ApplicationServices.Cars.Commands.Factory;
using Xunit;

namespace OnionArchitectureDemo.ApplicationServices.Tests.Cars.Commands.Factory
{
    public class CarFactoryTests
    {
        private CarFactory _subject;

        public CarFactoryTests()
        {
            _subject = new CarFactory();
        }

        [Theory]
        [InlineData("test make")]
        public void Create_SetsMakeValueInCarObjectToValuePassedIn(string make)
        {
            var result = _subject.Create(make, "test model", 9.65);

            Assert.Equal(make, result.Make);
        }

        [Fact]
        public void Create_WhenMakeIsNull_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => _subject.Create(null, "test model", 9.65));
        }

        [Theory]
        [InlineData("test model")]
        public void Create_SetsModelValueInCarObjectToValuePassedIn(string model)
        {
            var result = _subject.Create("test make", model, 9.65);

            Assert.Equal("test model", result.Model);
        }

        [Fact]
        public void Create_WhenModelIsNull_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => _subject.Create("test make", null, 9.65));
        }

        [Fact]
        public void Create_SetsPriceValueInCarObjectToValuePassedIn()
        {
            var result = _subject.Create("test make", "test model", 9.65);

            Assert.Equal(9.65, result.Price);
        }
    }
}
