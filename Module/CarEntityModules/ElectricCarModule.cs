using Autofac;
using ElectricCarPack;
using IRentACarApiPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModulesPack
{
    public class ElectricCarModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ElectricCar>().As<ICar>();
            base.Load(builder);
        }
    }
}
