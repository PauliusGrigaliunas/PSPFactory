using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICarManagerFasadePack;
using Autofac;
using ModulesPack;
using CarManagerControllerAPIPack;
using BicycleManagedControllerAPIPack;
using IRentControllerPack;

namespace PSPFactory
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var scope = Bootstrapper.Build().BeginLifetimeScope())
            {
                IRentController rentController = scope.Resolve<IRentController>();
                ICarManagerController carManagedControler = scope.Resolve<ICarManagerController>();
                IBicycleManagedControler bicycleManagedControler = scope.Resolve<IBicycleManagedControler>();               

                bool show = true;
                while (show)
                {
                    Console.WriteLine("-----Meniu-----");
                    Console.WriteLine("1. User");
                    Console.WriteLine("2. CarManager");
                    Console.WriteLine("3. BicycleManager");
                    Console.WriteLine("exit. Get out of the program");
                    Console.WriteLine("----------");
                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            rentController.LoadView();
                            break;
                        case "2":
                            carManagedControler.LoadView();
                            break;
                        case "3":
                            bicycleManagedControler.LoadView();
                            break;
                        case "exit":
                            show = false;
                            break;
                        default:
                            Console.WriteLine("Wrong option");
                            break;
                    }
                }
            }

        }
    }
}
