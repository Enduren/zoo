using System;
using System.Collections.Generic;
using System.Text;


namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            HasLegs = 4;
            DrinksWater = true;
            HasTail = true;
            NeedsAir = false;
        }

        public bool IsColdBlooded { get; set; } = true;
        public string LayEggs { get; set; } = "Hatches";

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Is Cold-Blooded: {IsColdBlooded}");
            Console.WriteLine($"Mobility: {LayEggs}");
        }
    }
}