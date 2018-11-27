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

            builder.RegisterModule<BicycleRentalAgreementServiceModule>();
            builder.RegisterModule<BicycleServiceModule>();
            builder.RegisterModule<CarRentalAgreementServiceModule>();
            builder.RegisterModule<CarServiceModule>();

            builder.RegisterModule<RentABicycleFasadeModule>();
            builder.RegisterModule<RentACarFasadeModule>();
            builder.RegisterModule<BicycleManagerFasadeModule>();
            builder.RegisterModule<CarManagerFasadeModule>();

            builder.RegisterModule<UIModule>();

            return builder.Build();
        }
    }
}
