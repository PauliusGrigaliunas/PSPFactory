using IRentACarApiPack;
using IRentControllerPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACarControlerPack
{
    public class RentACarView : IRentView
    {
        private IRentController _controller;

        public void AddController(IRentController controller)
        {
            _controller = controller;
        }

        public void ShowMenu()
        {
            bool show = true;

            while (show)
            {
                Console.WriteLine("-----CarManagerControl-----");
                Console.WriteLine("1. Select a car");
                Console.WriteLine("2. Sign a contract");
                Console.WriteLine("3. Make a deal");
                Console.WriteLine("4. Show all cars");
                Console.WriteLine("back. - Back to menu");
                Console.WriteLine("----------");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        TakeACar();
                        break;
                    case "2":
                        SignContract();
                        break;
                    case "3":
                        MakeADeal();
                        break;
                    case "4":
                        ShowAllCars();
                        break;
                    case "exit":
                    case "back":
                        show = false;
                        break;
                    default:
                        Console.WriteLine("No such option");
                        break;
                }
            }
        }

        private void TakeACar()
        {
            ShowAllCars();
            string carId = Console.ReadLine();
            ICar car = _controller.TakeVehile(carId);
            Console.WriteLine("You choose: ");
            ShowCarDetails(car.Id, car.Name, car.Model);
        }

        private void SignContract()
        {  
            Console.WriteLine("deal was made at: " + _controller.AssignRentalAgreement());
        }

        private void MakeADeal()
        {
            ShowAllCars();
            Console.WriteLine("Enter Car Id ");
            string id = Console.ReadLine();
            Console.WriteLine("Enter time for driving ");
            int time = Int32.Parse(Console.ReadLine());
            Console.WriteLine(  "Price: " + _controller.MakeADeal(id, time)); 
                
        }

        private void ShowAllCars()
        {
            Console.WriteLine("Cars: ");
            List<ICar> listOfCars = _controller.AllVehile();
            foreach (ICar car in listOfCars)
            {
                ShowCarDetails(car.Id, car.Name, car.Model);
            }
        }
        private void ShowCarDetails(string id, string name, string model)
        {
            Console.WriteLine("++++++++++++++");
            Console.WriteLine("Car ID (" + id + ")");
            Console.WriteLine(name + " " + model);
            Console.WriteLine("++++++++++++++");
            Console.WriteLine();
        }
    }
}
