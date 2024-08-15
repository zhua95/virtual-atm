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
    public partial class BillPayment : Form
    {
        private Bank currentAccount;
        public BillPayment()
        {
            InitializeComponent();
            currentAccount = Session_Manager.CurrentAccount;
            textBalance.Text = $"{currentAccount.GetChqBalance()}";
        }

        private void goButtonDeposit_Click(object sender, EventArgs e)
        {
            double enteredAmount = double.Parse(textWithdrawal.Text);
            if (enteredAmount <= currentAccount.GetChqBalance() && enteredAmount < 10000)
            {
                MessageBox.Show("Completed");
                currentAccount.BillPayment(enteredAmount);

            }
            else
            {
                MessageBox.Show("Insufficiet funds!");
            }

            textBalance.Text = currentAccount.GetChqBalance().ToString();
        }

        private void exitButtonDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            balanceButton homeshow = new balanceButton();
            homeshow.Show();
        }
    }
}
