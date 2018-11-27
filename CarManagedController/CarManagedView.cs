using CarManagerControllerAPIPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagedControllerPack
{
    public class CarManagedView : ICarManagerView
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
                System.Console.WriteLine("1. Write report\n");
                string choice = System.Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        WriteReport();
                        break;
                    case "exit":
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
            System.Console.WriteLine(orderInfo);
        }

        /*private void WriteReport()
        {
            System.Console.WriteLine("Enter accountant id: ");
            string accountantId = System.Console.ReadLine();
            System.Console.WriteLine("Enter report description: ");
            string description = System.Console.ReadLine();
            System.Console.WriteLine("Enter order id: ");
            string orderId = System.Console.ReadLine();
            _controller.WriteReport(accountantId, description, orderId);
        }*/
    }
}
