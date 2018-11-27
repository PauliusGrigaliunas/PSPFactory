using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using IRentABicycleFasadePack;
using RentBicycleUntilDayFasadePack;

namespace ModulesPack
{
    class RentABicycleFasadeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RentBicycleUntilDayFasade>().As<IRentABicycleFasade>();
            base.Load(builder);
        }
    }
}

