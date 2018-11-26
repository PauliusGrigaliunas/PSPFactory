using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using IRentABicycleApi;
using ElectricBicycleDiscountedRentalAgreementPack;

namespace ModulesPack.BicycleEntityModules
{
    public class DiscountedBicycleRentalAgreementModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DiscountedBicycleRentalAgreement>().As<IBicycleRentalAgreement>();
            base.Load(builder);
        }
    }
}
