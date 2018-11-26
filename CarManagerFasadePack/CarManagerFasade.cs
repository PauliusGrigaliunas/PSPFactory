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

        public ICar CreateCar(string firstName, string lastName)
        {
            ICar car = _rentACarFactory.TakeACar();
            _repositor.Add(car);
            return car;
        }
    }
}
