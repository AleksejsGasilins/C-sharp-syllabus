using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class SavingsAccount
    {
        private float _balance;
        private float _annualRate = 0;

        private float _totalDeposited = 0;
        private float _totalWithdrawn = 0;
        private float _totalInterestEarned = 0;

        public SavingsAccount(float balance)
        {
            _balance = balance;
        }

        public void setAnnualRate(float annualRate)
        {
            _annualRate = annualRate;
        }

        public float getMonthlyRate()
        {
            return _annualRate / 12;
        }

        public void withdraw(float amount)
        {
            _balance -= amount;
            _totalWithdrawn += amount;
        }

        public void addDeposit(float amount)
        {
            _balance += amount;
            _totalDeposited += amount;
        }

        public float getInterest()
        {
            var interest = _balance * getMonthlyRate();
            _totalInterestEarned += interest;
            _balance += interest;

            return interest;
        }

        public void calculation(int accountAge)
        {
            var currentCalculation = 1;

            while (accountAge >= currentCalculation)
            {
                addDeposit(GetInformation.getDepositAmount(currentCalculation));
                withdraw(GetInformation.getWithdrawAmount(currentCalculation));
                getInterest();

                currentCalculation++;
            }

            GetInformation.getTotalInformation
            (
                _totalDeposited,
                _totalWithdrawn,
                _totalInterestEarned,
                _balance
                );
        }
    }
}
