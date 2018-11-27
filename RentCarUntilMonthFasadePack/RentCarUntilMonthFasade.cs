using ICarRentServiceAPIPack;
using IRentACarApiPack;
using IRentACarFasadePack;
using System;
using System.Collections.Generic;

namespace RentCarUntilMonthFasadePack
{
    public class RentCarUntilMonthFasade : IRentACarFasade
    {
        private IRentACarFactory _rentACarFactory;
        private ICarService _carService;
        private ICarRentalAgreementService _carRentalAgreementService;

        public List<ICar> GetCarRepositor => _carService.AllCars();
        public List<ICarRentalAgreement> GetCarRentalAgreementRepositor => _carRentalAgreementService.AllAgreements();


        public RentCarUntilMonthFasade(ICarService carService, ICarRentalAgreementService carRentalAgreementService, IRentACarFactory rentACarFactory)
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
            ICar car = _carService.GetCar(id);
            _carService.TakeACar(car);
            return car;
        }

        public int AsignAgreement()
        {
            return _carRentalAgreementService.SignUpAgreement(_rentACarFactory.MakeCarRentalAgreement(DateTime.Now, DateTime.Today, 1)).DayOfYear;
        }
    }
}
