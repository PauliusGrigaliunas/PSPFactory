using System;

namespace IRentABicycleApi
{
    public class IBicycle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal TimeTax { get; set; }
        public int NumberOfSeats { get; set; }
    }
}
