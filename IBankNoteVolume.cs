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
        double Thickness { get; }
        bool Fold(int count);

    }
}
