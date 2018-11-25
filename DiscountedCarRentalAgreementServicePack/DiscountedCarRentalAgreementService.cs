using System;
using RepositionAPIPack;
using ICarRentServiceAPIPack;
using IRentACarApiPack;
using System.Collections.Generic;

namespace DiscountedCarRentalAgreementServicePack
{
    public class DiscountedCarRentalAgreementService : ICarRentalAgreementService
    {
        private ICarRentalAgreement _carRentalAgreement;
        private IRepositor<ICarRentalAgreement> _repositor;

        public DiscountedCarRentalAgreementService(ICarRentalAgreement carRentalAgreement, IRepositor<ICarRentalAgreement> repositor)
        {
            _carRentalAgreement = carRentalAgreement;
            _repositor = repositor;
        }
        public void SignUpAgreement()
        {
            _repositor.Add(_carRentalAgreement);
        }
    }
}
