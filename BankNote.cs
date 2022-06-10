﻿using System;
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

        public void Fold()
        {
            Width = Width / 4;
            Thickness = 4 * Thickness;
        }

        public override double volume
        {
            get { return Width * Length * Thickness;}
        }

    }
}
