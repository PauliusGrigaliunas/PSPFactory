using System;

namespace IRentACarApiPack
{
    public abstract class ICar
    {
        public string Id { get; protected set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal TimeTax { get; set; }
        public string Engine { get; set; }
        public int NumberOfSeats { get; set; }
        public int RecoveryTimes { get; set; }
    }
}
