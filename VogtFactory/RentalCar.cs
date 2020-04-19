using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class RentalCar
    {
        public string Name;
        public int NumberOfPeopleThatCanFit;

        RentalCarFactory rcf = new RentalCarFactory();

        public void DisplayCarInfo()
        {

            Console.WriteLine($"{Name} car can fit {NumberOfPeopleThatCanFit}");
        }

    }
}
