using System;
using RepositionAPIPack;
using ICarRentServiceAPIPack;
using IRentACarApiPack;
using System.Collections.Generic;

namespace RegularCarRentalAgreementServicePack
{
    public class RegularCarRentalAgreementService : ICarRentalAgreementService
    {
        private ICarRentalAgreement _carRentalAgreement;
        private IRepositor<ICarRentalAgreement> _repositor;

        public RegularCarRentalAgreementService(ICarRentalAgreement carRentalAgreement, IRepositor<ICarRentalAgreement> repositor)
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
