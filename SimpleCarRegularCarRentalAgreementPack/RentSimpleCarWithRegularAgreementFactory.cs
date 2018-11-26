using System;
using System.Collections.Generic;
using System.Text;
using IRentACarApiPack;

namespace SimpleCarRegularCarRentalAgreementPack
{
    public class RentSimpleCarWithRegularAgreementFactory : IRentACarFactory
    {
        private string _carId;
        private string _name;
        private string _model;
        private decimal _timeTax;
        private string _engine;
        private int _numberOfSeats;

        public RentSimpleCarWithRegularAgreementFactory(string name, string model, decimal timeTax, string engine, int numberOfSeats)
        {
            _name = name;
            _model = model;
            _timeTax = timeTax;
            _engine = engine;
            _numberOfSeats = numberOfSeats;
        }

        public RentSimpleCarWithRegularAgreementFactory(ICar car)
        {
            _carId = car.Id;
            _name = car.Name;
            _model = car.Model;
            _timeTax = car.TimeTax;
            _engine = car.Engine;
            _numberOfSeats = car.NumberOfSeats;
        }


        public ICarRentalAgreement MakeCarRentalAgreement()
        {
            DateTime dateTime = new DateTime();

            return new RegularCarRentalAgreement(dateTime.Date, dateTime.Date, 1m);
        }

        public ICar TakeACar()
        {
            return new SimpleCar(_name, _model, _timeTax, _engine, _numberOfSeats);
        }


    }
}
