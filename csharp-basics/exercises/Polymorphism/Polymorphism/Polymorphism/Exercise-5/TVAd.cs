namespace AdApp
{
    public class TVAd : Advert
    {
        private int _seconds;

        private int _rate;

        private bool _peakTime;

        public TVAd(int fee, int seconds, int rate, bool peakTime = false) : base(fee)
        {
            _seconds = seconds;
            _rate = rate;
            _peakTime = peakTime;
        }

        public override int Cost()
        {
            if (_peakTime == false)
            {
                return base.Cost() + _seconds * _rate;

            }
            else
            {
               return base.Cost() + _seconds * (_rate + _rate * 2);
            }
        }

        public override string ToString()
        {
            return base.ToString() + " - Variable costs = " + (Cost() - base.Cost()) + " - Total = " + Cost();
        }
    }
}