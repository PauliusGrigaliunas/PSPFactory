using System;
using System.Collections.Generic;
using ICarManagerFasadePack;
using ICarRentServiceAPIPack;
using IRentACarApiPack;
using RepositionAPIPack;

namespace CarManagerFasadePack
{
    public class CarManagerFasade : ICarManagerFasade
    {
        private IRentACarFactory _rentACarFactory;
        private IRepositor<ICar> _repositor;
        private ICarService  _carService;


        public List<ICar> GetRepositor => _repositor.GetAll();

        public CarManagerFasade(IRentACarFactory rentACarFactory, IRepositor<ICar> repositor, ICarService carService)
        {
            _rentACarFactory = rentACarFactory;
            _repositor = repositor;
            _carService = carService;
        }

        public ICar CreateCar(string name, string model, decimal timeTax, string engine, int numberOfSeats)
        {
            ICar car = _rentACarFactory.TakeACar(name, model, timeTax, engine, numberOfSeats);
            _carService.TakeACar(car);
            return car;
        }
        

        public void DeleteCar(string id)
        {
            _repositor.Delete(id);
        }


    }
}
