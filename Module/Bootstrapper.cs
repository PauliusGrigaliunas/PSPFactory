using System;
using Autofac;
using ModulesPack.BicycleEntityModules;

namespace ModulesPack
{
    public class Bootstrapper
    {

        public static IContainer Build()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<RentABicycleFactoryModule>();
            builder.RegisterModule<RentACarFactoryModule>();

            builder.RegisterModule<RepositorModule>();

            return builder.Build();
        }
    }
}
