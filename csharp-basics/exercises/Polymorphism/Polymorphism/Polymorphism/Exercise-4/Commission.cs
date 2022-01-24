namespace Exercise_4
{
    class Commission : Hourly
    {
        private double _commission;
        private double _totalSales;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commission) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commission = commission;
            _totalSales = 0.0;
        }

        public void AddSales(double totalSales)
        {
            _totalSales = totalSales;
        }

        public double GetCommissionBonus()
        {
           var commissionBonus = _totalSales * (100 * _commission);
           return commissionBonus;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal sales: " + _totalSales;
            result += "\nCommission: " + _commission;
            result += "\nCommission bonus: " + GetCommissionBonus();
            return result;
        }

        public override double Pay()
        {
            var paid = base.Pay() + GetCommissionBonus();
            _totalSales = 0.0;
            return paid;
        }
    }
}
