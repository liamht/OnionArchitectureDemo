using OnionArchitectureDemo.Web.Logic.Cars.ViewModels;

namespace OnionArchitectureDemo.Web.Logic.Cars.Services
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
