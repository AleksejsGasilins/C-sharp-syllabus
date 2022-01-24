namespace AdApp
{
    class Poster : Advert
    {
        private int _dimensions;
        private int _amountCopies;
        private int _rate;

        public Poster(int fee, int dimensions, int amountCopies, int rate) : base(fee)
        {
            _dimensions = dimensions;
            _amountCopies = amountCopies;
            _rate = rate;
        }

        public override int Cost()
        {
            return base.Cost() + (_dimensions * _amountCopies) * _rate;
        }

        public override string ToString()
        {
            return base.ToString() + " - Variable costs = " + (Cost() - base.Cost()) + " - Total = " + Cost();
        }
    }
}
