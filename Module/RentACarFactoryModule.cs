using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using IRentABicycleApi;
using SimpleBicycleRegularBicycleRentalAgreementPack;

namespace ModulesPack
{
    public class RentACarFactoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RentSimpleBicycleWithRegularAgreement>().As<IRentABicycleFactory>();
            base.Load(builder);
        }
    }
}
