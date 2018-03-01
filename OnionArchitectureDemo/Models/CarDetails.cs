using OnionArchitectureDemo.DomainServices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArchitectureDemo.Web.Models
{
    public class CarDetails
    {
        public string Model { get; set; }

        public string Make { get; set; }

        public bool HasSpareWheel { get; set; }

        public double Price { get; set; }

        public double PreSalePrice { get; set; }

        public string CarName => $"{Make} {Model}";

        public CarDetails(Car car, double presalePrice)
        {
            Model = car.Model;
            Make = car.Make;
            HasSpareWheel = car.HasSpareWheel;
            Price = car.Price;
            PreSalePrice = presalePrice;
        }
    }
}
