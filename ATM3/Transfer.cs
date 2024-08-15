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
    public partial class Transfer : Form
    {
        public Bank currentAccount;
        public Transfer()
        {
            InitializeComponent();
            currentAccount = Session_Manager.CurrentAccount;
            savBalanceText.Text = $"{currentAccount.GetSavBalance()}";
            chqBalanceText.Text = $"{currentAccount.GetChqBalance()}";
        }

        private void goButtonDeposit_Click(object sender, EventArgs e)
        {
            double enteredAmount = double.Parse(textWithdrawal.Text);
            if (enteredAmount <= currentAccount.GetChqBalance() && enteredAmount < 10000)
            {
                MessageBox.Show("Completed");
                currentAccount.Transfer(enteredAmount);

            }
            else
            {
                MessageBox.Show("Insufficient funds or amount over 10000");
            }

            savBalanceText.Text = currentAccount.GetSavBalance().ToString();
            chqBalanceText.Text = currentAccount.GetChqBalance().ToString();
        }

        private void exitButtonDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            balanceButton homeShow = new balanceButton();
            homeShow.Show();
        }
    }
}
