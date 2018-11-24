using System;

namespace IRentABicycleApi
{
    public class IBicycleRentalAgreement
    {
        public string Id { get; protected set; }
        public DateTime DateNow { get; set; }
        public DateTime Date {get; set;}
        public DateTime Time { get; set; }
        public decimal Distance { get; set; }
        public decimal Discount { get; set; }
    }
}
