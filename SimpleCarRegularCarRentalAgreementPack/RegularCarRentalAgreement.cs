using System;
using System.Collections.Generic;
using System.Text;
using IRentACarApiPack;

namespace SimpleCarRegularCarRentalAgreementPack
{
    public class RegularCarRentalAgreement: ICarRentalAgreement
    {
        public RegularCarRentalAgreement(DateTime date, DateTime time, decimal distance)
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
