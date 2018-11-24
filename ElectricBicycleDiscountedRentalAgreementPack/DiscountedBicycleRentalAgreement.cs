using System;
using System.Collections.Generic;
using System.Text;
using IRentABicycleApi;

namespace ElectricBicycleDiscountedRentalAgreementPack
{
    class DiscountedBicycleRentalAgreement : IBicycleRentalAgreement
    {
        public DiscountedBicycleRentalAgreement()
        {
            Id = Guid.NewGuid().ToString();
        }

    }
}
