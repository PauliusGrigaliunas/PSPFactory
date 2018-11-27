using Autofac;
using BicycleManagedControllerAPIPack;
using BicycleManagedControllerPack;
using CarManagerControllerAPIPack;
using CarManagedControllerPack;
using IRentControllerPack;
using RentACarControlerPack;

namespace ModulesPack
{
    public class UIModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManagerController>().As<ICarManagerController>();
            builder.RegisterType<BicycleManagerController>().As<IBicycleManagedControler>();
            builder.RegisterType<RentACarControler>().As<IRentController>();

            builder.RegisterType<CarManagedView>().As<ICarManagerView>();
            builder.RegisterType<BicycleManagerView>().As<IBicycleManagerView>();
            builder.RegisterType<RentACarView>().As<IRentView>();
            base.Load(builder);
        }
    }
}
