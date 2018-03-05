using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArchitectureDemo.Web.Cars.ViewModels
{
    public class CreateCarViewModel
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }
    }
}
