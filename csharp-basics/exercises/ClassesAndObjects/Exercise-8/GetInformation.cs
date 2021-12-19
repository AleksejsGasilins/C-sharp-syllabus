using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise_8
{
    class GetInformation
    {
        public static float getBalanceAtStart()
        {
            Console.Write(("How much money is in the account? "));
            return float.Parse(Console.ReadLine());
        }

        public static float getAnnualRate()
        {
            Console.Write("Enter the annual interest rate: ");
            return float.Parse(Console.ReadLine());
        }

        public static int getAccountAge()
        {
            Console.Write("How long has the account been opened? ");
            return int.Parse(Console.ReadLine());
        }

        public static float getDepositAmount(int month)
        {
            Console.Write($"Enter amount deposited for month {month}: ");
            return float.Parse(Console.ReadLine());
        }

        public static float getWithdrawAmount(int month)
        {
            Console.Write($"Enter amount withdrawn for month {month}: ");
            return float.Parse(Console.ReadLine());
        }

        public static void getTotalInformation(float totalDeposited, float totalWithdrawn, float totalInterestEarned, float balance)
        {
            Console.WriteLine($"Total deposited: {NumberFormatter.moneyFormatter(totalDeposited)}");
            Console.WriteLine($"Total withdrawn: {NumberFormatter.moneyFormatter(totalWithdrawn)}");
            Console.WriteLine($"Interest earned: {NumberFormatter.moneyFormatter(totalInterestEarned)}");
            Console.WriteLine($"Ending balance: {NumberFormatter.moneyFormatter(balance)}");
        }
    }
}
