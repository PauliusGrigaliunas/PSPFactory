using System;

namespace IRentACarApiPack
{
    public interface IRentACarFactory
    {
        ICar TakeACar();
        ICarRentalAgreement MakeCarRentalAgreement();

    }
}
