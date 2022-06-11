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
        int brokenNumber = 0;
        public double Shake(List<Money> moneyBox, double currentVolume) 
        {
            currentVolume = 0;
            foreach (var item in moneyBox)
            {
                currentVolume += (item.volume + item.volume*0.25);
            }

            return currentVolume;
        }

        public double GetAmount(ref List<Money> moneyBox, double currentAmount) 
        {
            currentAmount = 0;
            foreach (var item in moneyBox)
            {
                currentAmount += item.amount;
            }
            moneyBox = new List<Money>();
            return currentAmount;
        }

        //public double GetVolume(List<Money> moneyBox)
        //{
        //    double currentVolume = 0;
        //    Random random = new Random();
        //    double randomVol = random.Next(25, 76);
        //    randomVol = randomVol / 100;

        //    foreach (var item in moneyBox)
        //    {
                
        //        currentVolume += (item.volume + item.volume * randomVol);
        //    }

        //    return currentVolume;
        //}

        public int Break()
        {
            brokenNumber++;           
            return brokenNumber;
        }

        public List<Money> moneyBox = new List<Money>();

    }
}
