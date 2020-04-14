using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class Yamaha : RentalCar
    {
        public string name;
        public int numberOfPeopleThatCanFit;
        public Yamaha()
        {
            this.name = "Motorcycle";
            this.numberOfPeopleThatCanFit = 1;

        }

        public override void DisplayCarInfo()
        {
            Console.WriteLine($"{name} car can fit {numberOfPeopleThatCanFit}");
        }
    }
}
