namespace Exercise_4
{
    class Commission : Hourly
    {
        private double _commission;
        private double _totalSales;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commission) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commission = commission;
        }

        public void AddSales(double totalSales)
        {
            var employeePay = new Employee().Pay();
        }
    }
}
