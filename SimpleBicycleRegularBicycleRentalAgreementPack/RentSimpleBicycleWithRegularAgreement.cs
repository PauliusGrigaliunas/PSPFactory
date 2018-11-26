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

        public IBicycle TakeABicycle()
        {
            return new SimpleBicycle("a", "a", 0.1m, 5);
        }
    }
}
