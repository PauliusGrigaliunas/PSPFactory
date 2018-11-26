using System;
using System.Collections.Generic;
using System.Text;
using IRentABicycleApi;

namespace ElectricBicycleDiscountedRentalAgreementPack
{
    class RentElectricBicycleWithDiscountedAgreement : IBicycleRentalAgreement
    {
        public IBicycleRentalAgreement MakeBicycleRentalAgreement()
        {
            DateTime dateTime = new DateTime();

            return new DiscountedBicycleRentalAgreement(dateTime.Date, dateTime.Date, 1m, 0.1m);
        }

        public IBicycle TakeABicycle()
        {
            return new ElectricBicycle("a", "a", 0.1m, "b", 5);
        }
    }
}
