using OnionArchitectureDemo.Web.Cars.ViewModels;

namespace OnionArchitectureDemo.Web.Cars.Services
{
    public interface ICreateCarViewModelFactory
    {
        CreateCarViewModel Create();
    }
}