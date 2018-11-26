using Autofac;
using IRentACarApiPack;
using SimpleCarRegularCarRentalAgreementPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModulesPack
{
    public class RegularCarRentalAgreementModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegularCarRentalAgreement>().As<ICarRentalAgreement>();
            base.Load(builder);
        }
    }
}
