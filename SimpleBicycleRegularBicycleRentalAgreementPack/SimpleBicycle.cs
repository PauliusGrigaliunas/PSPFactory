using System;
using System.Collections.Generic;
using System.Text;
using IRentABicycleApi;

namespace SimpleBicycleRegularBicycleRentalAgreementPack
{
    public class SimpleBicycle : IBicycle
    {

        public SimpleBicycle(string name, string model, decimal timeTax, int numberOfSeats)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Model = model;
            TimeTax = timeTax;
            NumberOfSeats = numberOfSeats;
            RecoveryTimes = 0;
        }
    }
}
