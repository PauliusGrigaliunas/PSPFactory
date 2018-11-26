using System;

namespace IRentABicycleApi
{
    public interface IRentABicycleFactory
    {
        IBicycle TakeABicycle();
        IBicycleRentalAgreement MakeBicycleRentalAgreement();

    }
}
