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
    public partial class Withdraw : Form
    {
        private Bank currentAccount;
        public Withdraw()
        {
            InitializeComponent();
            currentAccount = Session_Manager.CurrentAccount;
            textBalance.Text = $"{currentAccount.GetChqBalance()}";


        }

        
        private void textBalance_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textWithdrawal_TextChanged(object sender, EventArgs e)
        {

        }

        private void goButtonWithdrawal_Click(object sender, EventArgs e)
        {
            double enteredAmount = double.Parse(textWithdrawal.Text);
            if(enteredAmount <= currentAccount.GetChqBalance() && enteredAmount < 1000)
            { 
                MessageBox.Show("Completed");
                currentAccount.WithdrawChq(enteredAmount);
               
            }
            else
            {
                MessageBox.Show("Insufficient funds!");
            }

            textBalance.Text = currentAccount.GetChqBalance().ToString();
        }

        private void exitButtonWithdrawal_Click(object sender, EventArgs e)
        {
            this.Hide();
            balanceButton form2show = new balanceButton();
            form2show.Show();
        }
    }
}
