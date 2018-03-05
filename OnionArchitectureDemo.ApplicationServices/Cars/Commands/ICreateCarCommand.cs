namespace OnionArchitectureDemo.ApplicationServices.Cars.Commands
{
    public interface ICreateCarCommand
    {
        void Execute(CreateCarModel model);
    }
}