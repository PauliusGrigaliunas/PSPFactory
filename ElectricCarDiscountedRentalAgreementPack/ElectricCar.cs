using System;
using System.Collections.Generic;
using System.Text;
using IRentACarApiPack;

namespace ElectricCarPack
{

    public class ElectricCar : ICar
    {
        public int RunningTime { get; set; }
        public ElectricCar(string name, string model, decimal timeTax, string engine, int runningTime, int numberOfSeats)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Model = model;   
            TimeTax = timeTax;
            Engine = engine;
            RunningTime = runningTime;
            NumberOfSeats = numberOfSeats;
            RecoveryTimes = 0;
        }
    }

}
