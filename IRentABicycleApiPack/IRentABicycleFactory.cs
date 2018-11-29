using System;

namespace IRentABicycleApi
{
    public interface IRentABicycleFactory
    {
        IBicycle TakeABicycle(string name, string model, decimal timeTax, int numberOfSeats);
        IBicycleRentalAgreement MakeBicycleRentalAgreement(DateTime date, DateTime time, Decimal distance);

    }
}
