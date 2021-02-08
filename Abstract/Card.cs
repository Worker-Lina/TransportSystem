using Enum;
using System;


namespace Abstract
{
    public abstract class Card
    {
        public DateTime RegistrationDate { get; set; }
        public string СardNumber { get; set; }
        public string BarcodeCard { get; set; }
        public double Balance { get; set; }
        public bool IsWork { get; set; }
        public UserStatus UserStatus { get; set; }
    }
}
