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

        public virtual void DisplayCarInfo()
        {
            Console.WriteLine($"{Name} {NumberOfPeopleThatCanFit}");
        }

    }
}
