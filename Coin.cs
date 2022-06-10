using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Coin: Money, ICoinVolume
    {
        public double Pi = 3.14;
        public double Height { get; set; }
        public double Diameter { get; set; }

        public override double volume
        {
            get { return Pi * Diameter * Diameter * Height / 1000; }
        }

    }
}
