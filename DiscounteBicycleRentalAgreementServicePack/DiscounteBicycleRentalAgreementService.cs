using IBicycleRentServiceAPIPack;
using IRentABicycleApi;
using RepositionAPIPack;
using System;

namespace DiscounteBicycleRentalAgreementServicePack
{
    public class DiscounteBicycleRentalAgreementService : IBicycleRentalAgreementService
    {
        private IBicycleRentalAgreement _bicycleRentalAgreement;
        private IRepositor<IBicycleRentalAgreement> _repositor;

        public DiscounteBicycleRentalAgreementService(IBicycleRentalAgreement bicycleRentalAgreement, IRepositor<IBicycleRentalAgreement> repositor)
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
