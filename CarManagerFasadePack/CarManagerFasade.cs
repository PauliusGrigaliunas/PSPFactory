using System;
using ICarManagerFasadePack;
using IRentACarApiPack;
using RepositionAPIPack;

namespace CarManagerFasadePack
{
    public class CarManagerFasade : ICarManagerFasade
    {
        private IRentACarFactory _rentACarFactory;
        private IRepositor<ICar> _repositor;

        public CarManagerFasade(IRentACarFactory rentACarFactory, IRepositor<ICar> repositor)
        {
            _rentACarFactory = rentACarFactory;
            _repositor = repositor;
        }

        public ICar CreateCar(string name, string model, int timeTax, string engine, int numberOfSeats)
        {
            ICar car = _rentACarFactory.TakeACar(name, model, timeTax, engine, numberOfSeats);
            _repositor.Add(car);
            return car;
        }
    }
}
