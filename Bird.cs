using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            HasLegs = 2;
            DrinksWater = true;
            HasTail = true;
            NeedsAir = false;
        }

        public bool HasWings { get; set; } = true;
        public bool Hasbeak { get; set; } = true;
        public bool GrabsWithFeet { get; set; } = true;

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Can Fly: {HasWings}");
            Console.WriteLine($"Specialty:{GrabsWithFeet} : Singing");
        }
    }
}