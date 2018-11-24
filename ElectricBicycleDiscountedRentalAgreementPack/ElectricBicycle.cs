using System;
using System.Collections.Generic;
using System.Text;
using IRentABicycleApi;

namespace ClassLibrary1ElectricBicycleDiscountedBicycleRentalAgreementPack
{
    class ElectricBicycle : IBicycle
    {
        public string Engine { get; set; }

        public ElectricBicycle(string name, string model, decimal timeTax, string engine,  int numberOfSeats)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Model = model;
            TimeTax = timeTax;
            Engine = engine;
            NumberOfSeats = numberOfSeats;
        }
    }
}
