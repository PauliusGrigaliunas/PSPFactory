using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using ElectricBicycleDiscountedRentalAgreementPack;
using IRentABicycleApi;

namespace ModulesPack.BicycleEntityModules
{
    public class ElectricBicycleModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ElectricBicycle>().As<IBicycle>();
            base.Load(builder);
        }
    }
}
