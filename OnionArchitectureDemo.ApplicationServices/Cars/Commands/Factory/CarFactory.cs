using OnionArchitectureDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureDemo.ApplicationServices.Cars.Commands.Factory
{
    public class CarFactory : ICarFactory
    {
        public Car Create(string make, string model, double price)
        {
            ThrowIfNull(make, "Make");
            ThrowIfNull(model, "Model");

            var car = new Car();

            car.Make = make;
            car.Model = model;
            car.Price = price;

            return car;
        }

        private void ThrowIfNull(object value, string propertyName)
        {
            if (value == null)
            {
                throw new ArgumentNullException($"{propertyName} cannot be null");
            }
        }
    }
}
