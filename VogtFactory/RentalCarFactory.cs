using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class RentalCarFactory
    {
        public static RentalCar CreateRentalCar(int maxSeats)
        {
            RentalCar rentalCar = new RentalCar();

            if (maxSeats <= 4 && maxSeats > 1)
            {
                rentalCar = new Toyota();
            }
            if (maxSeats <= 7 && maxSeats > 5)
            {
                rentalCar = new Dodge(); 
            }
            if (maxSeats == 5)
            {
                rentalCar = new Ford();
            }
            if (maxSeats == 1)
            {
                rentalCar = new Yamaha();
            }

            return rentalCar;
        }
    }
}
