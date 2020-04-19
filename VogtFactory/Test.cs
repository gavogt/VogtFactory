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

            for (int i = 1; i < 7; i++)
            {
                RentalCar car = RentalCarFactory.CreateRentalCar(i);

                Console.WriteLine($"Car that holds {i} people {car}");

                car.DisplayCarInfo();
            }
        }
    }

}