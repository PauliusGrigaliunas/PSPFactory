using System;
using System.Collections.Generic;
using System.Text;
using IRentABicycleApi;

namespace SimpleBicycleRegularBicycleRentalAgreementPack
{
    class RentSimpleBicycleWithRegularAgreement : IRentABicycleFactory
    {
        public IBicycleRentalAgreement MakeBicycleRentalAgreement()
        {
            DateTime dateTime = new DateTime();

            return new RegularBicycleRentalAgreement(dateTime.Date, dateTime.Date, 1m);
        }

        public IBicycleRentalAgreement MakeBicycleRentalAgreement(DateTime date, DateTime time, decimal distance)
        {
            return new RegularBicycleRentalAgreement(date, time, distance);
        }


        public IBicycle TakeABicycle(string name, string model, decimal timeTax, int numberOfSeats)
        {
            return new SimpleBicycle(name, model, timeTax, numberOfSeats);
        }
    }
}
