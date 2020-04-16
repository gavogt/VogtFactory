using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class RentalCarFactory
    {
        public RentalCar CreateRentalCar(string type)
        {
            RentalCar rentalCar = null;

            if (type.Equals("Toyota"))
            {
                rentalCar = new Toyota();
            }
            if (type.Equals("Dodge"))
            {
                rentalCar = new Dodge(); 
            }

            return rentalCar;
        }
    }
}
