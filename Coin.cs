using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Coin: Money, ICoinVolume
    {
        public double Pi = 3.24;
        public double Height { get; set; }
        public double Diameter { get; set; }
    }
}
