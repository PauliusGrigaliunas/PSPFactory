using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using IRentABicycleApi;
using SimpleBicycleRegularBicycleRentalAgreementPack;

namespace ModulesPack.BicycleEntityModules
{
    public class SimpleBicycleModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SimpleBicycle>().As<IBicycle>();
            base.Load(builder);
        }
    }
}
