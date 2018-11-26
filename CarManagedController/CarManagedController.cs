using System;
using CarManagedControllerAPIPack;
using IRentACarApiPack;
using IRentACarFasadePack;

namespace CarManagedControllerPack
{
    public class CarManagedController 
    {

        private ICar _car;
        private IEmployeeFacade _employeeFacade;

        public CarManagedController()
        {

        }

        public void CreateElectricCar(string name, string model, decimal timeTax, string engine, int runningTime, int numberOfSeats)
        {
            IAccountant accountant = _employeeFacade.CreateAccountant(firstName, lastName);
            return new ElectricCar(name, model, timeTax, engine, runningTime, numberOfSeats);
        }

        public ICar CreateSimpleCar(string name, string model, decimal timeTax, string engine, int numberOfSeats)
        {

            return new SimpleCar( name,  model, timeTax, engine, numberOfSeats);
        }
    }

}
