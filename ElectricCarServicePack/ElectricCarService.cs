using System;
using RepositionAPIPack;
using ICarRentServiceAPIPack;
using IRentACarApiPack;
using System.Collections.Generic;

namespace ElectricCarServicePack
{
    public class ElectricCarService : ICarService
    {

        private ICar _car;
        private IRepositor<ICar> _repositor;

        public ElectricCarService(ICar car, IRepositor<ICar> repositor)
        {
            _car = car;
            _repositor = repositor;
        }

        public void TakeACar()
        {
            _car.RecoveryTimes += 1;
            _repositor.Update(_car);
        }

        public ICar GetCar(string id)
        {
            return _repositor.GetById(id);
        }

        public int GetRecoveryTimes(string id)
        {
            return _repositor.GetById(id).RecoveryTimes;
        }

        public void AddACar(ICar car)
        {
            _repositor.Add(car);
        }

        public void DeleteCar(string id)
        {
            _repositor.Delete(id);
        }
        public void UpdateCar(ICar car)
        {
            _repositor.Update(car);
        }

        public List<ICar> AllCars()
        {
            return _repositor.GetAll();
        }
    }
}
