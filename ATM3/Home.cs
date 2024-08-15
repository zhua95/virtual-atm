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
    public partial class balanceButton : Form
    {
        private Bank currentAccount;
        public balanceButton()
        {
            InitializeComponent();
            currentAccount = Session_Manager.CurrentAccount;

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw withdrawshow = new Withdraw();
            withdrawshow.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CHQ =" + currentAccount.GetChqBalance().ToString());

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit depositshow = new Deposit();
            depositshow.Show();
        }

        private void billPaymentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillPayment billPaymentshow = new BillPayment();
            billPaymentshow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithdrawSavings withdrawSavingsShow = new WithdrawSavings();
            withdrawSavingsShow.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositSav depositSavShow = new DepositSav();
            depositSavShow.Show();
        }

        private void savButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SAV =" + currentAccount.GetSavBalance().ToString());
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer transfershow = new Transfer();
            transfershow.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logInShow = new Login();
            logInShow.Show();
        }
    }
}
