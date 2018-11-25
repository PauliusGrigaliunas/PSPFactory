using System;
using IRentACarApiPack;

namespace SimpleCarRegularCarRentalAgreementPack
{
    public class SimpleCar : ICar
    {
        public SimpleCar(string name, string model, decimal timeTax, string engine, int numberOfSeats)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Model = model;
            TimeTax = timeTax;
            Engine = engine;
            NumberOfSeats = numberOfSeats;
            RecoveryTimes = 0;
        }
    }
}
