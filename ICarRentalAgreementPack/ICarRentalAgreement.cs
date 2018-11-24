using System;

namespace ICarRentalAgreementPack
{
    public class ICarRentalAgreement
    {
        public DateTime Date {get; set;}
        public DateTime Time { get; set; }
        public decimal Distance { get; set; }
        public decimal Discount { get; set; }
    }
}
