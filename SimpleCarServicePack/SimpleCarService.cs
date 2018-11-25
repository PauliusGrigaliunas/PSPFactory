﻿using System;
using RepositionAPIPack;
using ICarRentServiceAPIPack;
using IRentACarApiPack;
using System.Collections.Generic;

namespace SimpleCarServicePack
{
    public class SimpleCarService : ICarService
    {
        private ICar _car;
        private IRepositor<ICar> _repositor;

        public SimpleCarService(ICar car, IRepositor<ICar> repositor)
        {
            _car = car;
            _repositor = repositor;
        }

        public void TakeACar()
        {
            _car.RecoveryTimes += 1;
            _repositor.Update(_car);
        }

        public List<ICar> GetAllOrders()
        {
            return _repositor.GetAll();
        }

        public ICar GetOrder(string id)
        {
            return _repositor.GetById(id);
        }

        public int GetRecoveryTimes(string id)
        {
            return _repositor.GetById(id).RecoveryTimes;
        }
    }
}
