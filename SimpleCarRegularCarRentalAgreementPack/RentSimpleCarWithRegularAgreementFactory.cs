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

        public RentSimpleCarWithRegularAgreementFactory()
        {

        }

        public ICarRentalAgreement MakeCarRentalAgreement(DateTime date, DateTime time, Decimal distance)
        {
            DateTime dateTime = new DateTime();
            return new RegularCarRentalAgreement(DateTime.Now, dateTime.Date, distance);
        }


        public ICar TakeACar(string name, string model, decimal timeTax, string engine, int numberOfSeats)
        {
            return new SimpleCar(name, model, timeTax, engine, numberOfSeats);
        }
    }
}
