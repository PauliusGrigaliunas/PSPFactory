using IRentACarApiPack;
using IRentControllerPack;
using System;
using System.Collections.Generic;

namespace RentABicycleControlerPack
{
    public class RentABicycleControler : IRentController
    {
        public List<ICar> AllCars()
        {
            throw new NotImplementedException();
        }

        public int AssignRentalAgreement()
        {
            throw new NotImplementedException();
        }


        public decimal MakeADeal(string id, int time)
        {
            throw new NotImplementedException();
        }

        public ICar TakeCar(string id)
        {
            throw new NotImplementedException();
        }

        public void LoadView()
        {
            throw new NotImplementedException();
        }
    }
}
