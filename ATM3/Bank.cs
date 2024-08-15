using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM3
{
    public class Bank
    {
        private string userName;
        private int accountNumber;
        private int pin;
        private double savBalance;
        private double chqBalance;

        public Bank(string UserName, int AccountNumber, int Pin, double SavBalance, double ChqBalance)
        {
            this.userName = UserName;
            this.accountNumber = AccountNumber;
            this.pin = Pin;
            this.savBalance = SavBalance;
            chqBalance = ChqBalance;
        }

        

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public int GetPin()
        {
            return pin;
        }
        
        public double GetSavBalance()
        {
            return savBalance;
        }

        public double GetChqBalance()
        {
            return chqBalance;
        }

        public void WithdrawChq(double amount)
        {  
           chqBalance =  chqBalance - amount;
        }

        public void DepositChq(double amount)
        {
            chqBalance = chqBalance + amount;
        }
        public void WithdrawSav(double amount)
        {
            savBalance = savBalance - amount;
        }
        public void DepositSav(double amount)
        {
            savBalance = savBalance + amount;
        }

        public void BillPayment(double amount)
        {
            chqBalance = chqBalance - amount - 1.25;
        }

        public void Transfer(double amount)
        {
            savBalance = amount + savBalance;
            chqBalance = chqBalance - amount;
        }
        public bool CheckPin(string enteredUser, int enteredPin)
        {
            return userName == enteredUser && pin == enteredPin;
        }

        public void PayInterest()
        {
            
        }
    }
}
