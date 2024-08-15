using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ATM3
{
    public partial class Login : Form
    {
        public Bank[] accounts;
        public Bank[] admin;
        
        public Login()
        {
            InitializeComponent();
            //Creating account "db"
            accounts = new Bank[]
                {
                    new Bank("Zach Huard", 1234, 1234, 100, 200),
                    new Bank("Dave Mustaine", 3456, 3456,175, 175),
                    new Bank("Picasso", 4567, 4567, 200, 300),
                    new Bank("Korben Dallas",0001, 1234,457.98,21.53),
                    new Bank("Jerry Cann",0002, 1234, 1027.63,790),
                    new Bank("Eric Clapton",0003, 1234 ,4.1,54.45),
                    new Bank("Carlos Santana",0004, 1234, 10657.84, 1083),
                    new Bank("Elton John", 0005, 1234,7210, 35)
                };
       
        }

        

        private void loginButton_Click(object sender, EventArgs e)
        {
            string enteredUserName = (textaccountNumber.Text);
            int enteredPinNo = int.Parse(textPin.Text);
            int loginAttempts = 0;

                if(loginAttempts >= 3)
            {
                Application.Exit();
            }
            
            
                if (PinVerify(enteredUserName, enteredPinNo))
                {

                    this.Hide();
                    balanceButton form2show = new balanceButton();
                    form2show.Show();
                }
                else if (AdminVerify(enteredUserName, enteredPinNo))
                {
                    this.Hide();
                    Admin adminshow = new Admin();
                    adminshow.Show();

                }
                else 
                {
                   
                    MessageBox.Show("Incorrect");
                    loginAttempts++;
     
                }
            
            

        }
        
        //Pin and username authentication
        private bool PinVerify(string enteredUserName, int enteredPinNo)
        {
            foreach (var account in accounts)
            {
                Session_Manager.SetCurrentAccount(account);
                if (account.CheckPin(enteredUserName, enteredPinNo)) { return true; }
            }
            return false;
        }

        private bool AdminVerify(string enteredUserName, int enteredPinNo)
        {
            if(enteredUserName == "Khalid Iqbal" && enteredPinNo == 1234)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textaccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
