using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using IRentABicycleApi;
using SimpleBicycleRegularBicycleRentalAgreementPack;

namespace ModulesPack.BicycleEntityModules
{
    public class RegularBicycleRentalAgreementModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegularBicycleRentalAgreement>().As<IBicycleRentalAgreement>();
            base.Load(builder);
        }
    }
}
