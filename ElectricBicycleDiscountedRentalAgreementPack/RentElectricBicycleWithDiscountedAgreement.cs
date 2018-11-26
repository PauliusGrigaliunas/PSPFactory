using System;
using System.Collections.Generic;
using System.Text;
using IRentABicycleApi;

namespace ElectricBicycleDiscountedRentalAgreementPack
{
    public class RentElectricBicycleWithDiscountedAgreement : IRentABicycleFactory
    {
        public IBicycleRentalAgreement MakeBicycleRentalAgreement(DateTime date, DateTime time, decimal distance)
        {
            return new DiscountedBicycleRentalAgreement(date, time, distance, 0.1m);
        }


        public IBicycle TakeABicycle(string name, string model, decimal timeTax, int numberOfSeats)
        {
            return new ElectricBicycle(name, model, timeTax, "Electro" , numberOfSeats);
        }
    }
}
