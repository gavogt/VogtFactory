using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class Dodge: RentalCar
    {
        public string Name = "minivan";
        public int NumberOfPeopleThatCanFit = 7;
        public Dodge()
        {


        }

        public override void DisplayCarInfo()
        {
            Console.WriteLine($"{Name} car can fit {NumberOfPeopleThatCanFit}");
        }
    }
}
