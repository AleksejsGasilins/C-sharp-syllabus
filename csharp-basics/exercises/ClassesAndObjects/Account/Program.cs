using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var bank = new Bank("Swedbank");

            bank.AddAccount(new Account(1, "Barto", 100));
            bank.AddAccount(new Account(2, "Ethan", 0));
            bank.AddAccount(new Account(3, "Calvin", 0));

            bank.Transfer(bank.GetAccountById(1), bank.GetAccountById(2), 50);
            bank.Transfer(bank.GetAccountById(2), bank.GetAccountById(3), 25);

            bank.DdrawAllAccounts();
            Console.ReadKey();
        }
    }
}
