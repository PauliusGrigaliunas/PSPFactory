using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using BicycleManagerFasadePack;
using IBicycleManagerFasadePack;

namespace ModulesPack
{
    class BicycleManagerFasadeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BicycleManagerFasade>().As<IBicycleManagerFasade>();
            base.Load(builder);
        }
    }
}
