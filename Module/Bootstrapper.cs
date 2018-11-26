using System;
using Autofac;

namespace ModulesPack
{
    public class Bootstrapper
    {

        public static IContainer Build()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<SimpleCarModule>();
            builder.RegisterModule<ElectricCarModule>();



            return builder.Build();
        }
    }
}
