using System;
using RepositionAPIPack;
using ICarRentServiceAPIPack;
using IRentACarApiPack;

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

        public int GetTotalInterest(SimpleCarService car)
        {
            return 0;
        }

        public void TakeACar()
        {
            _car.RecoveryTimes += 1;
        }
    }
}
