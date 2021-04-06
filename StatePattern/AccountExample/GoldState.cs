using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.AccountExample
{
    public class GoldState : State
    {
      
        public GoldState(State state)
        {
            this.Balance = state.Balance;
            this.Account = state.Account; 
        }

        private void Initialize()
        {
            interest = 0.05;
            lowerLimit = 1000.0;
            upperLimit = 10000000.0;
        }
        public GoldState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }
        public override void Deposit(double amount)
        {
            balance += amount;
        }

        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            balance -=  amount;
        }

        private void StateChangeCheck()
        {
            if(balance < 0.0)
            {
                account.State = new RedState(this);
            }
            else if(balance < lowerLimit)
            {
                account.State = new SilverState(this);
            }
        }
    }
}
