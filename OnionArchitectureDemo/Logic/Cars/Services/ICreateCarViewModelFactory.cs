using OnionArchitectureDemo.Web.Logic.Cars.ViewModels;

namespace OnionArchitectureDemo.Web.Logic.Cars.Services
{
    public interface ICreateCarViewModelFactory
    {
        CreateCarViewModel Create();
    }
}