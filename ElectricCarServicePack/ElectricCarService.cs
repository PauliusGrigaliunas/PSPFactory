using System;
using RepositionAPIPack;
using ICarRentServiceAPIPack;
using IRentACarApiPack;
using System.Collections.Generic;

namespace ElectricCarServicePack
{
    public class ElectricCarService : ICarService
    {
        private IRepositor<ICar> _repositor;

        public ElectricCarService( IRepositor<ICar> repositor)
        {
            _repositor = repositor;
        }

        public void TakeACar(ICar car)
        {
            string model = car.Model + " (electric)";
            car.Model = model;
            car.RecoveryTimes += 1;
            _repositor.Update(car);
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
           string model =  car.Model + " electric";
            car.Model = model;          
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
