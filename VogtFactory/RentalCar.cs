using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    abstract class RentalCar
    {
        public abstract string Name { get; }
        public abstract int NumberOfPeopleThatCanFit { get; }

        public void DisplayCarInfo()
        {

            Console.WriteLine($"{Name} car can fit {NumberOfPeopleThatCanFit}");
        }

    }
}
