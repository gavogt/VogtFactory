using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class Test
    {
        public static void Run()
        {
            RentalCar car = new Toyota();
            RentalCar car2 = new Ford();

            car.DisplayCarInfo();
            car2.DisplayCarInfo();
        }
    }
}
