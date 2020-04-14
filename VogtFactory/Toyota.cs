using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class Toyota : RentalCar
    {
        public string name;
        public int numberOfPeopleThatCanFit;
        public Toyota()
        {
            this.name = "Corolla";
            this.numberOfPeopleThatCanFit = 4;

        }

        public override void DisplayCarInfo()
        {
            Console.WriteLine($"{name} car can fit {numberOfPeopleThatCanFit}");
        }
    }
}
