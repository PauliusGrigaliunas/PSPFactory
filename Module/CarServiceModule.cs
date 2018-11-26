using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using ICarRentServiceAPIPack;
using SimpleCarServicePack;

namespace ModulesPack
{
    public class CarServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SimpleCarService>().As<ICarService>();
            base.Load(builder);
        }
    }
}
