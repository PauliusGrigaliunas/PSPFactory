using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using IRentACarApiPack;
using SimpleCarRegularCarRentalAgreementPack;

namespace ModulesPack
{
    public class RentABicycleFactoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RentSimpleCarWithRegularAgreementFactory>().As<IRentACarFactory>();
            base.Load(builder);
        }
    }
}
