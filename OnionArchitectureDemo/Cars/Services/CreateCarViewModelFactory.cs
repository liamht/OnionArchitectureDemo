using OnionArchitectureDemo.Web.Cars.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArchitectureDemo.Web.Cars.Services
{
    public class CreateCarViewModelFactory : ICreateCarViewModelFactory
    {
        public CreateCarViewModelFactory()
        {
        }

        public CreateCarViewModel Create()
        {
            var viewModel = new CreateCarViewModel();

            return viewModel;
        }
    }
}
