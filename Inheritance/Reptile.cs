using System;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool IsVenomous { get; set; }
        public bool IsPoisonous { get; set; }
        public bool IsAquatic { get; set; }
        public string ScalePattern { get; set; }
    }
}
