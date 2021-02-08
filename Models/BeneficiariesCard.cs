using Abstract;
using System;

namespace Models
{
    public class BeneficiariesCard : Card
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IIN { get; set; }

    }
}
