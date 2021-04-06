using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.AccountExample
{
    public class RedState : State
    {
        private double _serviceFee;
        public RedState(State state)
        {
            this.Account = state.Account;
            this.balance = state.Balance;
        }

        public RedState(double balance, Account account)
        {
            this.Balance = balance;
            this.Account = Account;
            Initialize();
        }

        private void Initialize()
        {
            interest = 0.0;
            lowerLimit = -100.0;
            upperLimit = 0.0;
            _serviceFee = 15.00;
        }
        public override void Deposit(double amount)
        {
            balance += amount;
            StatusChangeCheck();
        }

        public override void PayInterest()
        {
            throw new NotImplementedException();
        }

        public override void Withdraw(double amount)
        {
            amount = amount - _serviceFee;
            Console.WriteLine("No funds available for Withdrawl");
        }

        private void StatusChangeCheck()
        {
            if(balance > upperLimit)
            {
                account.State = new SilverState(this);
            }
        }
    }
}
