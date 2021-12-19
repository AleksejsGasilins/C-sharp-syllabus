namespace Account
{
    class Account
    {
        private string _name;
        private double _balance;
        private int _id;
        public Account(int id, string name, double balance)
        {
            _id = id;
            _balance = balance;
            _name = name;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public bool CheckBalance(double amount)
        {
            if (_balance - amount >= 0)
            {
                return true;
            }

            return false;
        }

        public void Withdrawal(double amount)
        {
            if (CheckBalance(amount))
            {
                _balance -= amount;
            }
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }
    }
}
