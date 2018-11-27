using System;
using System.Collections.Generic;
using CarManagerControllerAPIPack;
using ICarManagerFasadePack;
using IRentACarApiPack;
using IRentACarFasadePack;
using RepositionAPIPack;

namespace CarManagedControllerPack
{
    public class CarManagerController : ICarManagerController
    {

        private ICar _car;
        private ICarManagerFasade _carManagerFasade;
        private ICarManagerView _view;

        public CarManagerController(ICarManagerFasade carManagerFasade, ICarManagerView view)
        {
         
            _carManagerFasade = carManagerFasade;
            _view = view;
            _view.AddController(this);
        }

        public void AddCar(string name, string model, decimal timeTax, string engine, int numberOfSeats)
        {
            var car = _carManagerFasade.CreateCar(name, model, timeTax, engine, numberOfSeats);
            _view.ShowCarDetails(car.Id, car.Name, car.Model);
        }

        public void LoadView()
        {
            _view.ShowMenu();
        }

        public List<ICar> AllCars()
        {           
            return _carManagerFasade.GetRepositor;
        }

        public void DeleteCar(string id)
        {
            _carManagerFasade.DeleteCar(id);
        }
    }

}
