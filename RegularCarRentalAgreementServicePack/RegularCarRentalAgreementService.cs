using System;
using RepositionAPIPack;
using ICarRentServiceAPIPack;
using IRentACarApiPack;
using System.Collections.Generic;

namespace RegularCarRentalAgreementServicePack
{
    public class RegularCarRentalAgreementService : ICarRentalAgreementService
    {
        private IRepositor<ICarRentalAgreement> _repositor;

        public RegularCarRentalAgreementService(IRepositor<ICarRentalAgreement> repositor)
        {
            _repositor = repositor;
        }

        public List<ICarRentalAgreement> AllAgreements()
        {
            return _repositor.GetAll();
        }

        public DateTime SignUpAgreement(ICarRentalAgreement _carRentalAgreement)
        {
            _repositor.Add(_carRentalAgreement);
            return _carRentalAgreement.DateNow;
        }
    }
}
