﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM3
{
    public partial class DepositSav : Form
    {
        public Bank currentAccount;
        public DepositSav()
        {
            InitializeComponent();
            currentAccount = Session_Manager.CurrentAccount;
            textBalance.Text = $"{currentAccount.GetSavBalance()}";
        }

        private void goButtonDeposit_Click(object sender, EventArgs e)
        {
            double enteredAmount = double.Parse(textDeposit.Text);
            if (enteredAmount > 0)
            {
                MessageBox.Show("Completed");
                currentAccount.DepositSav(enteredAmount);
                textBalance.Text = $"{currentAccount.GetSavBalance()}";

            }
            else
            {
                MessageBox.Show("Insufficient funds or no value input");
            }

            textBalance.Text = $"{currentAccount.GetSavBalance()}";
        }

        private void exitButtonDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            balanceButton form2show = new balanceButton();
            form2show.Show();
        }
    }
}
