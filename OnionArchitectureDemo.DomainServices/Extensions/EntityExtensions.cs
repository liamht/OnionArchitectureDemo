using OnionArchitectureDemo.DomainServices.Entities;

namespace OnionArchitectureDemo.DomainServices.Extensions
{
    internal static class EntityExtensions
    {
        internal static Car ToBusinessEntity(this Data.Entities.Car car)
        {
            return new Car()
            {
                HasSpareWheel = car.HasSpareWheel,
                Make = car.Make,
                Model = car.Model,
                Price = car.Price,
                SalesListingId = car.SalesListingId
            };
        }

        internal static Sale ToBusinessEntity(this Data.Entities.Sale sale)
        {
            return new Sale()
            { 
                 MarkDownPercentage = sale.MarkDownPercentage
            };
        }
    }
}
