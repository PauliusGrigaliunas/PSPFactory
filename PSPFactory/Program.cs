using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICarManagerFasadePack;
using Unity;

namespace PSPFactory
{
    class Program
    {

        static void Main(string[] args)
        {
            ICarManagerFasade carManagerFasade;
            carManagerFasade = new CarManagerFasade();


            bool show = true;
            while (show)
            {
                Console.WriteLine("1. Manager\n2. Accountant\n3. Salesman\n");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        managerController.LoadView();
                        break;
                    case "2":
                        accountantController.LoadView();
                        break;
                    case "3":
                        salesmanController.LoadView();
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
