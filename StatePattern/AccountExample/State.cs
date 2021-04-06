using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.AccountExample
{
    public abstract class State
    {
        protected Account account;
        protected double balance;

        protected double interest;
        protected double lowerLimit;
        protected double upperLimit;
        public double Balance 
        { 
            get { return balance; }
            set {balance = value; }
        }

        public Account Account 
        {
            get{ return account;}
            set { account = value; }
        }
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();
        
    }
}
