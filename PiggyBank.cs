using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class PiggyBank
    {
        public double volume = 100;
        public double Shake(List<Money> moneyBox, double currentVolume) 
        {
            currentVolume = 0;
            foreach (var item in moneyBox)
            {
                currentVolume += (item.volume + item.volume*0.25);
            }

            return currentVolume;
        }

        public void Break() { }

        public List<Money> moneyBox = new List<Money>();

    }
}
