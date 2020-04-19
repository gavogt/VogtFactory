using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class RentalCar
    {
        public virtual string Name { get; }
        public virtual int NumberOfPeopleThatCanFit { get; }

        public void DisplayCarInfo()
        {

            Console.WriteLine($"{Name} car can fit {NumberOfPeopleThatCanFit}");
        }

    }
}
