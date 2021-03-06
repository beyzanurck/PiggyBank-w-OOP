using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PiggyBank
{
    class BankNote : Money, IBankNoteVolume
    {
        public double Width { get; set; }

        public double Length { get; set; }

        public double Thickness { get; set; }
        public bool folded = false;

        public bool Fold()
        {
            if (!folded)
            {
                Width = Width / 4;
                Thickness = 4 * Thickness;
                folded = true;
            }
            return true;
        }

        public override double volume
        {
            get { return Width * Length * Thickness / 1000;}
        }

    }
}
