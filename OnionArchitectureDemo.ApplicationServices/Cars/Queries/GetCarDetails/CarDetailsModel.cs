using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarDetails
{
    public class CarDetailsModel
    {
        public double Price { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double PreSalePrice { get; set; }
    }
}
