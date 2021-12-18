using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount("Benson", -17.25f);

            bankAccount.GetAccountData();

            Console.ReadKey();
        }
    }
}
