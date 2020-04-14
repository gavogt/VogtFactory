using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class Dodge: RentalCar
    {
        public string name;
        public int numberOfPeopleThatCanFit;
        public Dodge()
        {
            this.name = "minivan";
            this.numberOfPeopleThatCanFit = 7;

        }

        public override void DisplayCarInfo()
        {
            Console.WriteLine($"{name} car can fit {numberOfPeopleThatCanFit}");
        }
    }
}
