using IRentACarApiPack;
using System;
using System.Collections.Generic;

namespace ICarManagerFasadePack
{
    public interface ICarManagerFasade
    {
        List<ICar> GetRepositor { get; }
        ICar CreateCar(string name, string model, decimal timeTax, string engine, int numberOfSeats);
        void DeleteCar(string id);
    }
}
