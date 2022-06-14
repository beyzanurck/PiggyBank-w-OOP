using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressOfVolume.Visible = true;
        }

        List<Money> listOfMoney = new List<Money>();  
        PiggyBank piggyBank = new PiggyBank();
        ProgressBar progressBar = new ProgressBar();

        bool isFolded = false;

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

            progressBar.Maximum = Convert.ToInt32(piggyBank.volume);
            progressBar.Minimum = 0;
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            if (piggyBank.brokenNumber < 2)
            {
                foreach (var item in listOfMoney)
                {
                    if (cmbSelectMoney.SelectedItem == item.name)
                    {
                        if (item is BankNote && isFolded == false)
                        {
                            MessageBox.Show("You must fold banknotes to put into the box!");
                            break;
                        }
                        else
                        {
                            if (!piggyBank.AddMoney(item))
                            {
                                MessageBox.Show("The box is full");
                            }

                            isFolded = false;                            
                        }

                        progressOfVolume.Value = Convert.ToInt32(piggyBank.currentVolume);
                        progressBar.Update();
                    }
                }
            }
            else
            {
                MessageBox.Show("Your box is broken so you can't use it anymore!");
            }           
        }

        private void btnFoldMoney_Click(object sender, EventArgs e)
        {
            if (piggyBank.brokenNumber <2)
            {
                foreach (var item in listOfMoney)
                {
                    if (cmbSelectMoney.SelectedItem == item.name)
                    {
                        if (item is BankNote)
                        {
                            isFolded = ((BankNote)item).Fold();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("This is coin, you can't fold it!");
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You can't add more money since the box is broken");
            }
            
        }

        private void btnShakeBox_Click(object sender, EventArgs e)
        {
            if (piggyBank.brokenNumber < 2)
            {
                piggyBank.Shake();
                progressOfVolume.Value = Convert.ToInt32(piggyBank.currentVolume);
                progressBar.Update();
            }
            else
            {
                MessageBox.Show("You can't shake the box since it is broken");
            }
        }

        private void btnBreakBox_Click(object sender, EventArgs e)
        {
            double amountOfMoney = piggyBank.GetAmount();
            piggyBank.Break();

            if (piggyBank.brokenNumber == 1 || piggyBank.brokenNumber == 2)
            {
                pctBrokenOne.Left = 3;

                MessageBox.Show(String.Format("You have {0} TL", amountOfMoney.ToString()));

                if (piggyBank.brokenNumber == 1)
                {
                    pctFixedOne.Left = 3;
                    MessageBox.Show("Remember! You can fix it only once!");
                }
                else
                {
                    pctFixedOne.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Your box is already broken! You can't fix it anymore");
            }

            progressOfVolume.Value = Convert.ToInt32(piggyBank.currentVolume);
            progressBar.Update();
        }
    }    
}
