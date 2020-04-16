using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class RentalCar
    {
        string name;
        int numberOfPeopleThatCanFit;

        RentalCarFactory rcf = new RentalCarFactory();

        public RentalCar orderCar(string type)
        {
            RentalCar rc;

            rc = rcf.CreateRentalCar(type);

            return rc;
        }

        public virtual void DisplayCarInfo()
        {
            Console.WriteLine($"{name} {numberOfPeopleThatCanFit}");
        }

    }
}
