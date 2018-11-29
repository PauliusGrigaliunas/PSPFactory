using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using IBicycleRentServiceAPIPack;
using SimpleBicycleServicePack;

namespace ModulesPack
{
    public class BicycleServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SimpleBicycleService>().As<IBicycleService>();
            base.Load(builder);
        }
    }
}
