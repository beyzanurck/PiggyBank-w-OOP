﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Money> listOfMoney = new List<Money>();      

        PiggyBank piggyBank = new PiggyBank();
        double currentVolume = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            listOfMoney.Add(new BankNote() 
            { name = "2 Hundred TL", amount = 200, Width = 160, Length=72, Thickness=0.25}) ;
            listOfMoney.Add(new BankNote()
            { name = "1 Hundred TL", amount = 100, Width = 154, Length = 72, Thickness = 0.25 });
            listOfMoney.Add(new BankNote()
            { name = "50 TL", amount = 50, Width = 148, Length = 68, Thickness = 0.25 });
            listOfMoney.Add(new BankNote()
            { name = "20 TL", amount = 20, Width = 142, Length = 68, Thickness = 0.25 });
            listOfMoney.Add(new BankNote()
            { name = "10 TL", amount = 10, Width = 136, Length = 64, Thickness = 0.25 });
            listOfMoney.Add(new BankNote()
            { name = "5 TL", amount = 5, Width = 130, Length = 64, Thickness = 0.25 });

            listOfMoney.Add(new Coin() 
            {name = "1 TL", amount = 1, Diameter = 26.15, Height = 1.9});
            listOfMoney.Add(new Coin()
            { name = "50 krs", amount = 0.50, Diameter = 23.85, Height = 1.9 });
            listOfMoney.Add(new Coin()
            { name = "25 krs", amount = 0.25, Diameter = 20.5, Height = 1.65 });
            listOfMoney.Add(new Coin()
            { name = "10 krs", amount = 0.10, Diameter = 18.5, Height = 1.65 });
            listOfMoney.Add(new Coin()
            { name = "5 krs", amount = 0.05, Diameter = 17.5, Height = 1.65 });
            listOfMoney.Add(new Coin()
            { name = "1 krs", amount = 0.01, Diameter = 16.5, Height = 1.35 });


            foreach (var item in listOfMoney)
            {
                cmbSelectMoney.Items.Add(item.name);
            }

        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            foreach (var item in listOfMoney)
            {
                if (cmbSelectMoney.SelectedItem == item.name)
                {
                    piggyBank.moneyBox.Add(item);
                    currentVolume += item.volume;

                    MessageBox.Show(currentVolume.ToString());
                }
            }
        }
    }
}
