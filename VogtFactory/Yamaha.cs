using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class Yamaha : RentalCar
    {
        public string Name = "Motorcycle";
        public int NumberOfPeopleThatCanFit = 1;
        public Yamaha()
        {


        }

        public override void DisplayCarInfo()
        {
            Console.WriteLine($"{Name} car can fit {NumberOfPeopleThatCanFit}");
        }
    }
}
