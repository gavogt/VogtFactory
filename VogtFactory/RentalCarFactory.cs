using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class RentalCarFactory
    {

        public static RentalCar CreateRentalCar(int maxSeats)
        {
            if (maxSeats <= 4 && maxSeats > 1)
            {
                return new Toyota();
            }
            if (maxSeats <= 7 && maxSeats > 5)
            {
                return new Dodge(); 
            }
            if (maxSeats == 5)
            {
                return new Ford();
            }
            if (maxSeats == 1)
            {
                return new Yamaha();
            }

            return null;
        }
    }
}
