using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM3
{
    public partial class Admin : Form
    {
        private double atmBalance = 10000;
        public Bank[] accounts;
        public Admin()
        {
            InitializeComponent();
            accounts = new Bank[]
                {
                    new Bank("Zach Huard", 1234, 1234, 100, 200),
                    new Bank("Dave Mustaine", 3456, 3456,175, 175),
                    new Bank("Picasso", 4567, 4567, 200, 300)
                };
            
            
        }
        //Had a lot of trouble and did not leave myself enough time to complete the system admin properly :(
        private void outOfServiceButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refillButton_Click(object sender, EventArgs e)
        {
            double enteredAmount = double.Parse(textRefill.Text);
            if ( enteredAmount % 5000 == 0  && atmBalance < 20000)
            {
                MessageBox.Show("Completed");
                atmBalance = atmBalance + enteredAmount;

            }
            else
            {
                MessageBox.Show("Maximum atm balance = 20 000");
            }

            textBalance.Text = atmBalance.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            foreach(var account in accounts)
            {
                accountsBox.Text = accounts.ToString();
            }
        }
    }
}
