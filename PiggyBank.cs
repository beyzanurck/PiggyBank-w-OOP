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
        public int brokenNumber = 0;
        public double currentVolume=0;
        public double currentAmount =0;
        public List<Money> moneyBox = new List<Money>();

        public double Shake() 
        {
            currentVolume = 0;
            foreach (var item in moneyBox)
            {
                currentVolume += (item.volume + item.volume*0.25);
            }

            return currentVolume;
        }

        public double GetAmount() 
        {
            currentAmount = 0;
            foreach (var item in moneyBox)
            {
                currentAmount += item.amount;
            }
            return currentAmount;
        }

        public bool AddMoney(Money money)
        {
            if (brokenNumber >= 2) return false;

            Random random = new Random();
            double randomVol = random.Next(25, 76);
            randomVol = randomVol / 100;

            moneyBox.Add(money);
            currentVolume += money.volume + money.volume * randomVol;
            currentAmount += money.amount;

            if (currentVolume > volume)
            {
                moneyBox.Remove(money);
                currentVolume -= (money.volume + money.volume * randomVol);
                currentAmount -= money.amount;
                return false;
            }
            return true;
        }

        public void Break()
        {
            brokenNumber++;
            moneyBox = new List<Money>();
            currentVolume=0;
            currentAmount = 0;
        }


    }
}
