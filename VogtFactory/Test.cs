using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class Test
    {
        public static void Run()
        {
            var rcf = new RentalCarFactory();
            var toyota = rcf.CreateRentalCar("Toyota");
            var dodge = rcf.CreateRentalCar("Dodge");
            var yamaha = rcf.CreateRentalCar("Yamaha");
            var ford = rcf.CreateRentalCar("Ford");

            toyota.DisplayCarInfo();
            dodge.DisplayCarInfo();
            yamaha.DisplayCarInfo();
            ford.DisplayCarInfo();
        }
    }

}