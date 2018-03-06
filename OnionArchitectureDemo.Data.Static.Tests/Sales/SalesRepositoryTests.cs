using OnionArchitectureDemo.Data.Static.Sales;
using Xunit;

namespace OnionArchitectureDemo.Data.Static.Tests.Sales
{
    public class SalesRepositoryTests
    {

        [Fact]
        public void Constructor_SetsUpData()
        {
            var result = new SalesRepository();
            
            Assert.NotEmpty(result.StaticData);
        }
    }
}
