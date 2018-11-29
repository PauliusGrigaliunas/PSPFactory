using IRentACarApiPack;
using RepositionAPIPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCarServicePack
{
    public class SimpleCarServiceManager
    {
        private ICar _car;
        private IRepositor<ICar> _repositor;

        public SimpleCarServiceManager(IRepositor<ICar> repositor)
        {
            _repositor = repositor;
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
