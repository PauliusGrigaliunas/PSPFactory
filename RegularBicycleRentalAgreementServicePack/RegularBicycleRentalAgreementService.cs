using System;
using IBicycleRentServiceAPIPack;
using IRentABicycleApi;
using RepositionAPIPack;

namespace RegularBicycleRentalAgreementServicePack
{
    public class RegularBicycleRentalAgreementService : IBicycleRentalAgreementService
    {
        private IBicycleRentalAgreement _bicycleRentalAgreement;
        private IRepositor<IBicycleRentalAgreement> _repositor;

        public RegularBicycleRentalAgreementService(IBicycleRentalAgreement bicycleRentalAgreement, IRepositor<IBicycleRentalAgreement> repositor)
        {
            _bicycleRentalAgreement = bicycleRentalAgreement;
            _repositor = repositor;
        }

        public void SignUpAgreement()
        {
            _repositor.Add(_bicycleRentalAgreement);
        }
    }
}
