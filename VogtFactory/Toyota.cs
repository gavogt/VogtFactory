using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class Toyota : RentalCar
    {
        public override string Name => "Corolla";
        public override int NumberOfPeopleThatCanFit => 4;

    }
}
