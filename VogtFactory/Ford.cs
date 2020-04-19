using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory
{
    class Ford : RentalCar
    {
        public override string Name => "Escape Hybrid";
        public override int NumberOfPeopleThatCanFit => 5;

    }
}
