using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using BicycleManagedControllerAPIPack;
using BicycleManagedControllerPack;
using CarManagedControllerAPIPack;
using CarManagedControllerPack;
using IRentControllerPack;
using RentACarControlerPack;

namespace ModulesPack
{
    class UIModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManagedController>().As<ICarManagedControler>();
            builder.RegisterType<BicycleManagerController>().As<IBicycleManagedControler>();
            builder.RegisterType<RentACarControler>().As<IRentController>();

            builder.RegisterType<SalesmanView>().As<ISalesmanView>();
            builder.RegisterType<ManagerView>().As<IManagerView>();
            builder.RegisterType<AccountantView>().As<IAccountantView>();
            base.Load(builder);
        }
    }
}
