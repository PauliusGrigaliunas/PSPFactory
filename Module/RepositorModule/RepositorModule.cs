using System;
using System.Collections.Generic;
using Autofac;
using RepositionAPIPack;
using System.Text;
using IRentACarApiPack;
using RentACarRepositoryPack;
using IRentABicycleApi;
using RentABicycleRepositoryPack;

namespace ModulesPack
{
    public class RepositorModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(new CarRepository()).As<IRepositor<ICar>>();
            builder.RegisterInstance(new CarRentalAgreementsRepository()).As<IRepositor<ICarRentalAgreement>>();
            builder.RegisterInstance(new BicycleRepository()).As<IRepositor<IBicycle>>();
            builder.RegisterInstance(new BicycleRentalAgreementsRepository()).As<IRepositor<IBicycleRentalAgreement>>();
            base.Load(builder);
        }

    }
}
