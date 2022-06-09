using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class BankNote : Money, IBankNoteVolume
    {
        
        public double Width => throw new NotImplementedException();

        public double Length => throw new NotImplementedException();

        public double thickness => throw new NotImplementedException();

        public void Fold()
        {
            throw new NotImplementedException();
        }
    }
}
