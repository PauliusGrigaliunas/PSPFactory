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

        public RentElectricCarWithDiscountedAgreementFactory(string name, string model, decimal timeTax, string engine, int runningTime, int numberOfSeats)
        {
            _name = name;
            _model = model;
            _timeTax = timeTax;
            _engine = engine;
            _runningTime = runningTime;
            _numberOfSeats = numberOfSeats;
        }

        public RentElectricCarWithDiscountedAgreementFactory(ElectricCar car)
        {
            _carId = car.Id;
            _name = car.Name;
            _model = car.Model;
            _timeTax = car.TimeTax;
            _engine = car.Engine;
            _runningTime = car.RunningTime;
            _numberOfSeats = car.NumberOfSeats;
        }

        public ICarRentalAgreement MakeCarRentalAgreement()
        {
            DateTime dateTime = new DateTime();

            return new DiscountedCarRentalAgreement(dateTime.Date, dateTime.Date, 1m, 0.1m);
        }

        public ElectricCar TakeACar(string name, string model, decimal timeTax, string engine, int runningTime, int numberOfSeats)
        {
            return new ElectricCar(name, model, timeTax, engine, runningTime, numberOfSeats);
        }

    }
}
