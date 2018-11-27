using IRentACarApiPack;
using IRentControllerPack;
using System;
using System.Collections.Generic;
using IRentACarFasadePack;

namespace RentACarControlerPack
{
    public class RentACarControler : IRentController
    {

        private IRentACarFasade _rentACarFasade;
        private IRentView _view;

        public RentACarControler(IRentACarFasade a, IRentView view)
        {

             _rentACarFasade = a;
            _view = view;
            _view.AddController(this);
        }

        public List<ICar> AllCars()
        {
            return _rentACarFasade.GetCarRepositor;
        }

        public int AssignRentalAgreement()
        {

            return _rentACarFasade.AsignAgreement();
        }


        public decimal MakeADeal(string id, int time)
        {
           return _rentACarFasade.ReturnACar(id, time);
        }

        public ICar TakeCar(string id)
        {
            return _rentACarFasade.TakeACarById(id);
        }

        public void LoadView()
        {
            _view.ShowMenu();
        }
    }
}
