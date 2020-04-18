using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class Ford : RentalCar
    {
        public string Name = "Escape Hybrid";
        public int NumberOfPeopleThatCanFit = 5;
        public Ford()
        {


        }

        public override void DisplayCarInfo()
        {
            Console.WriteLine($"{Name} car can fit {NumberOfPeopleThatCanFit}");
        }
    }
}
