using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using IRentACarFasadePack;
using RentCarUntilDayFasadePack;

namespace ModulesPack
{
    public class RentACarFasadeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RentCarUntilDayFasade>().As<IRentACarFasade>();
            base.Load(builder);
        }
    }
}
