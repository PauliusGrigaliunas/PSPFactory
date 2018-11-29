using IRentControllerPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentABicycleControlerPack
{
    public class RentABicycleView : IRentView
    {
        public void AddController(IRentController controller)
        {
            bool show = true;

            while (show)
            {
                System.Console.WriteLine("1. Select Bicycle\n");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":

                        break;
                    case "exit":
                        show = false;
                        break;
                    default:
                        Console.WriteLine("No such option");
                        break;
                }
            }
        }

        public void ShowMenu()
        {
            throw new NotImplementedException();
        }
    }
}
