using CarManagerControllerAPIPack;
using IRentACarApiPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagedControllerPack
{
    public class CarManagerView : ICarManagerView
    {
        private ICarManagerController _controller;

        public void AddController(ICarManagerController controller)
        {
            _controller = controller;
        }

        public void ShowMenu()
        {
            bool show = true;

            while (show)
            {
                Console.WriteLine("-----CarManagerControl-----");
                Console.WriteLine("1. Add a car");
                Console.WriteLine("2. Delete a car");
                Console.WriteLine("3. Show all cars");
                Console.WriteLine("back. - Back to menu");
                Console.WriteLine("----------");
                string choice = System.Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddCar();
                        break;
                    case "2":
                        DeleteCar();
                        break;
                    case "3":
                        ShowAllCars();
                        break;
                    case "exit":
                    case "back":
                        show = false;
                        break;
                    default:
                        System.Console.WriteLine("No such option");
                        break;
                }

            }
        }

        public void ShowReportDetails(string reportId, string reportInfo)
        {
            var orderInfo = string.Format("ReportId: {0}, Info: {1}", reportId, reportInfo);
            Console.WriteLine(orderInfo);
        }

        private void AddCar()
        {
            Console.WriteLine("Enter Car Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Car Model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Enter Car Time Tax E/min: ");
            decimal timeTax = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Engine: ");
            string engine = Console.ReadLine();
            Console.WriteLine("Enter number of seats: ");
            int numberOfSeats = Convert.ToInt32(Console.ReadLine());
            _controller.AddCar(name, model, timeTax, engine, numberOfSeats);
        }
        private void DeleteCar()
        {
            Console.WriteLine("Enter car ID which you want delete: ");
            string id = Console.ReadLine();
            _controller.DeleteCar(id);
        }
        private void ShowAllCars()
        {
            Console.WriteLine("Cars: ");
            List<ICar> listOfCars = _controller.AllCars();
            foreach (ICar car in listOfCars)
            {
                ShowCarDetails(car.Id, car.Name, car.Model);
            }
        }

        public void ShowCarDetails(string id, string name, string model)
        {
            Console.WriteLine("++++++++++++++");
            Console.WriteLine("Car ID (" + id + ")");
            Console.WriteLine(name + " " + model);
            Console.WriteLine("++++++++++++++");
            Console.WriteLine();
        }


    }
}
