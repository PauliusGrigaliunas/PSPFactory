using System;
using System.Collections.Generic;
using System.Text;
using IRentABicycleApi;

namespace SimpleBicycleRegularBicycleRentalAgreementPack
{
    class RegularBicycleRentalAgreement : IBicycleRentalAgreement
    {
        public RegularBicycleRentalAgreement( DateTime date, DateTime time, decimal distance, decimal discount)
        {
            Id = Guid.NewGuid().ToString();
            DateNow = DateTime.Now;
            Date = date;
            Time = time;
            Distance = distance;
            Discount = discount;
        }

        public void CheckTime()
        {
            DateNow = DateTime.Now;
        }
    }
}
