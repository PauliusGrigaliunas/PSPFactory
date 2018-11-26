using System;
using System.Collections.Generic;
using System.Text;
using IRentACarApiPack;

namespace ElectricCarPack
{
    public class RentElectricCarWithDiscountedAgreementFactory : IRentACarFactory
    {
        private string _carId;
        private string _name;
        private string _model;
        private decimal _timeTax;
        private string _engine;
        private int _runningTime; 
        private int _numberOfSeats;

        public RentElectricCarWithDiscountedAgreementFactory()
        {}

        public ICarRentalAgreement MakeCarRentalAgreement(DateTime date, DateTime time, Decimal distance)
        {

            return new DiscountedCarRentalAgreement(date, time, distance, 0.1m);
        }

        public ICar TakeACar(string name, string model, decimal timeTax, string engine, int numberOfSeats)
        {
            return new ElectricCar(name, model, timeTax, engine, 24, numberOfSeats);
        }

    }
}
