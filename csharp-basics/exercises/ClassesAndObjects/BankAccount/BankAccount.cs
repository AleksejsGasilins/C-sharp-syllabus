using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        private string _name;
        private float _balance;

        public BankAccount(string name, float balance)
        {
            _name = name;
            _balance = balance;
        }

        public void GetAccountData()
        {
            if (_balance >= 0)
            {
                Console.Write($"{_name} $ {string.Format("{0:0.00}", _balance)}");
            }
            else
            {
                Console.Write($"{_name} -$ {string.Format("{0:0.00}", _balance * -1)}");
            }
        }
    }
}
