using IRentACarApiPack;
using System;
using System.Collections.Generic;

namespace ICarRentServiceAPIPack
{
    public interface ICarService
    {
        void TakeACar();
        ICar GetCar(string id);
        int GetRecoveryTimes(string id);
        void AddACar(ICar car);
        void DeleteCar(string id);
        void UpdateCar(ICar car);
        List<ICar> AllCars();
    }
}