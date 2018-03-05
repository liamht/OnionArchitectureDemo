using OnionArchitectureDemo.ApplicationServices.Cars.Commands.Factory;
using OnionArchitectureDemo.DomainServices.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureDemo.ApplicationServices.Cars.Commands
{
    public class CreateCarCommand : ICreateCarCommand
    {
        private ICarFactory _factory;
        private IUnitOfWork _uow;

        public CreateCarCommand(ICarFactory factory, IUnitOfWork uow)
        {
            _factory = factory;
            _uow = uow;
        }

        public void Execute(CreateCarModel model)
        {
            var car = _factory.Create(model.Make, model.Model, model.Price);

            _uow.Cars.Add(car);
            _uow.SaveChanges();
        }
    }
}
