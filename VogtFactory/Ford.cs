using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class Ford : RentalCar
    {
        public string name;
        public int numberOfPeopleThatCanFit;
        public Ford()
        {
            this.name = "Escape Hybrid";
            this.numberOfPeopleThatCanFit = 5;

        }

        public override void DisplayCarInfo()
        {
            Console.WriteLine($"{name} car can fit {numberOfPeopleThatCanFit}");
        }
    }
}
