using IRentACarApiPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICarRentServiceAPIPack
{
    public interface ICarRentalAgreementService
    {
        DateTime SignUpAgreement(ICarRentalAgreement _carRentalAgreement);
        List<ICarRentalAgreement> AllAgreements();
    }
}
