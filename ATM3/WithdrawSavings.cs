using System;
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
    public partial class WithdrawSavings : Form
    {
        private Bank currentAccount;
        public WithdrawSavings()
        {
            InitializeComponent();
            currentAccount = Session_Manager.CurrentAccount;
            textBalance.Text = $"{currentAccount.GetSavBalance()}";
        }

        private void goButtonWithdrawal_Click(object sender, EventArgs e)
        {
            double enteredAmount = double.Parse(textWithdrawal.Text);
            if (enteredAmount <= currentAccount.GetSavBalance() && enteredAmount < 1000)
            {
                MessageBox.Show("Completed");
                currentAccount.WithdrawSav(enteredAmount);

            }
            else
            {
                MessageBox.Show("Insufficient funds!");
            }

            textBalance.Text = currentAccount.GetSavBalance().ToString();
        }

        private void exitButtonWithdrawal_Click(object sender, EventArgs e)
        {
            this.Hide();
            balanceButton form2show = new balanceButton();
            form2show.Show();
        }
    }
}
