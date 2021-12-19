using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var balance = GetInformation.getBalanceAtStart();
            var savingAccount = new SavingsAccount(balance);

            var annualRate = GetInformation.getAnnualRate();
            savingAccount.setAnnualRate(annualRate);

            var accountAge = GetInformation.getAccountAge();
            savingAccount.calculation(accountAge);
        }
    }
}
