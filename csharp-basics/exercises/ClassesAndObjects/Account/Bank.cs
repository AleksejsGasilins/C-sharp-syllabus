using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Bank
    {
        private string _name;
        private List<Account> _accounts = new List<Account>();

        public Bank(string name)
        {
            _name = name;
        }

        public void AddAccount(Account accounts)
        {
            _accounts.Add(accounts);
        }

        public Account GetAccountById(int id)
        {
            foreach (var account in _accounts)
            {
                if (account.GetId() == id)
                {
                    return account;
                }
            }

            return null;
        }

        public void Transfer(Account from, Account to, double amount)
        {
            if (from.CheckBalance(amount) && from != null && to != null)
            {
                from.Withdrawal(amount);
                to.Deposit(amount);
            }
        }

        public void DdrawAllAccounts()
        {
            foreach (var account in _accounts)
            {
                Console.WriteLine($"{account.GetId()} {account.GetName()} {account.GetBalance()}.");
            }
        }
    }
}
