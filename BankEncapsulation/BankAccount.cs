using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    class BankAccount
    {
        public BankAccount()
        {
        }

        private double balance = 0;
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance += value;
            }
        }

        public void Deposit(double i)
        {
            balance += i;
        }
        public void Withdraw(double i)
        {
            balance -= i;
        }

        public double GetBalance()
        {
            return Balance;
        }
    }


}
