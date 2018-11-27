using IRentACarApiPack;
using System;
using System.Collections.Generic;

namespace IRentControllerPack
{
    public interface IRentController
    {
        void LoadView();

        ICar TakeCar(string id);
        int AssignRentalAgreement();
        decimal MakeADeal(string id, int time);
        List<ICar> AllCars();
    }
}
