using Autofac;
using IRentACarApiPack;
using SimpleCarRegularCarRentalAgreementPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModulesPack
{
    public class SimpleCarModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SimpleCar>().As<ICar>();
            base.Load(builder);
        }
    }
}
