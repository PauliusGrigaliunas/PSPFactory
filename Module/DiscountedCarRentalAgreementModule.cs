using Autofac;
using ElectricCarPack;
using IRentACarApiPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModulesPack
{
    class DiscountedCarRentalAgreementModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DiscountedCarRentalAgreement>().As<ICarRentalAgreement>();
            base.Load(builder);
        }
    }
}
