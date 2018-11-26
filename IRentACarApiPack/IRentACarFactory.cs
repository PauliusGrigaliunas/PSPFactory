using System;

namespace IRentACarApiPack
{
    public interface IRentACarFactory
    {
        ICar TakeACar(string name, string model, decimal timeTax, string engine, int numberOfSeats);
        ICarRentalAgreement MakeCarRentalAgreement(DateTime date, DateTime time, Decimal distance);

    }
}
