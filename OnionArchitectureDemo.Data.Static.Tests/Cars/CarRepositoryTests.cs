using OnionArchitectureDemo.Data.Static.Cars;
using Xunit;

namespace OnionArchitectureDemo.Data.Static.Tests.Cars
{
    public class CarRepositoryTests
    {
        [Fact]
        public void Constructor_SetsUpData()
        {
            var result = new CarRepository();

            Assert.NotEmpty(result.StaticData);
        }
    }
}
