using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using ICarRentServiceAPIPack;
using RegularCarRentalAgreementServicePack;

namespace ModulesPack
{
    public class CarRentalAgreementServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegularCarRentalAgreementService>().As<ICarRentalAgreementService>();
            base.Load(builder);
        }
    }
}
