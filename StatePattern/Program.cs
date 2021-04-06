using StatePattern.AccountExample;
using StatePattern.MainConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context c = new Context(new ConcreteStateA());

            //Issue Request which toggles state
            /* These are for main concept
                        c.Request();
                        c.Request();
                        c.Request();
                        c.Request();
                        */

            /* For Account State*/

            Account account = new Account("Jim Johnson");

            // Apply Account Transactions

            account.Deposit(500.00);
            account.Deposit(300.00);
            account.Withdraw(1000.00);
            account.Deposit(10000000.0);

            Console.ReadLine();
        }
    }
}
