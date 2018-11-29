using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using IBicycleRentServiceAPIPack;
using RegularBicycleRentalAgreementServicePack;

namespace ModulesPack
{
    public class BicycleRentalAgreementServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegularBicycleRentalAgreementService>().As<IBicycleRentalAgreementService>();
            base.Load(builder);
        }
    }
}
