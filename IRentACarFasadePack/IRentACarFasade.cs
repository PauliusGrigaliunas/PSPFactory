using IRentACarApiPack;
using System;
using System.Collections.Generic;

namespace IRentACarFasadePack
{
    public interface IRentACarFasade
    {
        List<ICar> GetCarRepositor { get; }
        List<ICarRentalAgreement> GetCarRentalAgreementRepositor { get; }
        ICar TakeACarById(string id);
        int AsignAgreement();
        decimal ReturnACar(string id, int time);

    }
}
