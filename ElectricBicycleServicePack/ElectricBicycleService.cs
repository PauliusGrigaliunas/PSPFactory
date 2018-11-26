using IBicycleRentServiceAPIPack;
using IRentABicycleApi;
using RepositionAPIPack;
using System;
using System.Collections.Generic;

namespace ElectricBicycleServicePack
{
    public class ElectricBicycleService : IBicycleService
    {
        private IBicycle _bicycle;
        private IRepositor<IBicycle> _repositor;

        public ElectricBicycleService(IBicycle bicycle, IRepositor<IBicycle> repositor)
        {
            _bicycle = bicycle;
            _repositor = repositor;
        }
        public void TakeABicycle()
        {
            _bicycle.RecoveryTimes += 1;
            _repositor.Update(_bicycle);
        }
        public IBicycle GetBicycle(string id)
        {
            return _repositor.GetById(id);
        }
        public int GetRecoveryTimes(string id)
        {
            return _repositor.GetById(id).RecoveryTimes;
        }
        public void AddABicycle(IBicycle bicycle)
        {
            _repositor.Add(bicycle);
        }
        public void DeleteBicycle(string id)
        {
            _repositor.Delete(id);
        }
        public void UpdateBicycle(IBicycle bicycle)
        {
            _repositor.Update(bicycle);
        }
        public List<IBicycle> AllBicycles()
        {
            return _repositor.GetAll();
        }
    }
}
