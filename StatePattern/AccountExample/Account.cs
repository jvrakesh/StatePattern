using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.AccountExample
{
 //Context Class
    public class Account
    {
        private string _owner;
        private State _state;
        public Account(string owner)
        {
            this._owner = owner;
            this._state = new SilverState(0.0, this);
        }

        public double Balance 
        {
            get { return _state.Balance; }
        }

        public State State 
        {
            get { return this._state;}
            set { _state = value;}
        }
        public void Deposit(double amount)
        {
            _state.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C} ---", this.Balance);
            Console.WriteLine(" Status =  {0}", this.State.GetType().Name);
            Console.WriteLine("");
        }

        public void Withdraw(double amount)
        {
            _state.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balace = {0:C} --", this.Balance);
            Console.WriteLine(" Status = {0}\n --", this.State.GetType().Name);
            Console.WriteLine("");
        }

        public void PayInterest()
        {
            _state.PayInterest();
            Console.WriteLine("Interest Paid {0:C} --- " );
            Console.WriteLine(" Balace = {0:C} --", this.Balance);
            Console.WriteLine(" Status = {0}\n --", this.State.GetType().Name);
            Console.WriteLine("");
        }
    }
}
