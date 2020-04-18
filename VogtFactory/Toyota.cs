using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class Toyota : RentalCar
    {
        public string Name = "Corolla";
        public int NumberOfPeopleThatCanFit = 4;


        public override void DisplayCarInfo()
        {
            Console.WriteLine($"{Name} car can fit {NumberOfPeopleThatCanFit}");
        }
    }
}
