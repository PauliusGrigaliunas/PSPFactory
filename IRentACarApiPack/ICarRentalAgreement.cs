using System;

namespace IRentACarApiPack
{
    public abstract class ICarRentalAgreement
    {
        public string Id { get; protected set; }
        public DateTime DateNow { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public decimal Distance { get; set; }
        public decimal Discount { get; set; }
    }
}
