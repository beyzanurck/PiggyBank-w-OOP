using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Money
    {
        public string name;
        public virtual double volume
        {
            get { return 0; }
        }

        public double amount;
    }
}
