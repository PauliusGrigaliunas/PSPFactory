using System;
using System.Collections.Generic;
using ICarRentServiceAPIPack;
using IRentACarApiPack;
using IRentACarFasadePack;
using RepositionAPIPack;
using SimpleCarServicePack;

namespace RentCarUntilDayFasadePack
{
    public class RentCarUntilDayFasade : IRentACarFasade
    {
        private IRentACarFactory _rentACarFactory;
        private ICarService _carService;
        private ICarRentalAgreementService _carRentalAgreementService;

        public List<ICar> GetCarRepositor => _carService.AllCars();
        public List<ICarRentalAgreement> GetCarRentalAgreementRepositor => _carRentalAgreementService.AllAgreements();


        public RentCarUntilDayFasade(ICarService carService, ICarRentalAgreementService carRentalAgreementService, IRentACarFactory rentACarFactory)
        {
            _carService = carService;
            _carRentalAgreementService = carRentalAgreementService;
            _rentACarFactory = rentACarFactory;
        }


        public decimal ReturnACar(string id, int time)
        {
            ICar car = _carService.GetCar(id);
            return car.TimeTax * time;
        }

        public ICar TakeACarById(string id)
        {          
               ICar car =_carService.GetCar(id);
            _carService.TakeACar(car);
            return car;
        }

        public int AsignAgreement()
        {
           return _carRentalAgreementService.SignUpAgreement(_rentACarFactory.MakeCarRentalAgreement(DateTime.Now, DateTime.Today, 1)).DayOfYear;
        }
    }
}
