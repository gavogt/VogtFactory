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

            for (int seats = 1; seats < 7; seats++)
            {
                RentalCar car = RentalCarFactory.CreateRentalCar(seats);
                if(car == null)
                {
                    Console.WriteLine("describe error!");
                }
                else
                {
                    Console.WriteLine($"Car that holds {seats} people {car}");

                    car.DisplayCarInfo();
                }
            }
        }
    }
}