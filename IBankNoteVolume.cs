using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    interface IBankNoteVolume
    {
        double Width { get; }
        double Length { get; }
        double thickness { get; }
        void Fold();

    }
}
