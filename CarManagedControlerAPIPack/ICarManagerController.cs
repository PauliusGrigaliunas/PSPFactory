using IRentACarApiPack;
using System;
using System.Collections.Generic;

namespace CarManagerControllerAPIPack
{
    public interface ICarManagerController
    {
        void LoadView();
        void AddCar(string name, string model, decimal timeTax, string engine, int numberOfSeats);
        void DeleteCar(string id);
        List<ICar> AllCars();
    }
}
