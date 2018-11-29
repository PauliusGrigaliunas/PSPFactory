using System;
using System.Collections.Generic;
using System.Text;
using IRentABicycleApi;

namespace SimpleBicycleRegularBicycleRentalAgreementPack
{
    public class RegularBicycleRentalAgreement : IBicycleRentalAgreement
    {
        public RegularBicycleRentalAgreement( DateTime date, DateTime time, decimal distance)
        {
            Id = Guid.NewGuid().ToString();
            DateNow = DateTime.Now;
            Date = date;
            Time = time;
            Distance = distance;
            Discount = 0;
        }

        public void CheckTime()
        {
            DateNow = DateTime.Now;
        }
    }
}
