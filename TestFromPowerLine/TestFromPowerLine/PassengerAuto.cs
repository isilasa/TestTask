using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFromPowerLine
{
    public class PassengerAuto : Auto
    {
        private int countOfPassenger;
        public int CountOfPassenger
        {
            get
            {
                return countOfPassenger;
            }
            set
            {
                if (value > 4 || value < 0)
                    throw new ArgumentOutOfRangeException("The vehicle cannot accommodate more than 4 passengers");
                else
                    countOfPassenger = value;
            }
        }
        public PassengerAuto(int countOfPassenger)
        {
            CountOfPassenger = countOfPassenger;
            Type = TypeAuto.Passenger;
        }

        public override int KilometersLeft()
            => base.KilometersLeft() - countOfPassenger * 6 / 100;
    }
}
