using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using CarManagerFasadePack;
using ICarManagerFasadePack;

namespace ModulesPack
{
    public class CarManagerFasadeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManagerFasade>().As<ICarManagerFasade>();
            base.Load(builder);
        }
    }
}
