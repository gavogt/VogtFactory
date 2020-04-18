using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class RentalCarFactory
    {
        public RentalCar CreateRentalCar(string type)
        {
            RentalCar rentalCar = new RentalCar();

            if (type.Equals("Toyota"))
            {
                rentalCar = new Toyota();
            }
            if (type.Equals("Dodge"))
            {
                rentalCar = new Dodge(); 
            }
            if (type.Equals("Ford"))
            {
                rentalCar = new Ford();
            }
            if (type.Equals("Yamaha"))
            {
                rentalCar = new Yamaha();
            }

            return rentalCar;
        }
    }
}
