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
            var car = new Car();

            car.Make = make;
            car.Model = model;
            car.Price = price;

            return car;
        }
    }
}
