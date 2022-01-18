using System;

namespace AdApp
{
    public class Hoarding : Advert
    {
        private int _rate;
        //per day
        private int _numDays;

        private bool _primeLocation;

        public Hoarding(int fee, int numDays, int rate, bool primeLocation = false) : base(fee)
        {
            _numDays = numDays;
            _rate = rate;
            _primeLocation = primeLocation;
        }

        public override int Cost()
        {
            if (_primeLocation == false)
            {
                return base.Cost() + _numDays * _rate;
            }
            else
            {
                return Convert.ToInt32(base.Cost() + _numDays * (_rate + _rate * 0.5));

            }
        }

        public override string ToString()
        {
            return base.ToString() + " - Variable costs = " + (Cost() - base.Cost()) + " - Total = " + Cost();
        }
    }
}