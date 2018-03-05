using OnionArchitectureDemo.Domain.Entities;

namespace OnionArchitectureDemo.ApplicationServices.Cars.Commands.Factory
{
    public interface ICarFactory
    {
        Car Create(string make, string model, double price);
    }
}