﻿using System;
using RepositionAPIPack;
using ICarRentServiceAPIPack;
using IRentACarApiPack;
using System.Collections.Generic;

namespace SimpleCarServicePack
{
    public class SimpleCarService : ICarService
    {
        private IRepositor<ICar> _repositor;

        public SimpleCarService( IRepositor<ICar> repositor)
        {
            _repositor = repositor;
        }

        public void TakeACar(ICar car)
        {
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
