﻿using System;

namespace IRentACarApiPack
{
    public class ICar
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal TimeTax { get; set; }
        public string Engine { get; set; }
        public int NumberOfSeats { get; set; }
    }
}
