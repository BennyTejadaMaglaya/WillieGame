namespace WillieGame
{
    public partial class WillieHand
    {
        private int _CardOne;
        private int _CardTwo;
        private int _Willie;
        public WillieHand(int CardOne, int CardTwo)
        {
            _CardOne = CardOne;
            _CardTwo = CardTwo;
        }
        public int Willie
        {
            get
            {
                if (_CardOne > 10)
                    _Willie = 10;
                else _Willie = _CardOne;
                if (_CardTwo > 10)
                    _Willie = 10;
                else _Willie = _CardTwo;
                return _Willie;
            }
        }
        public int CardOne
        {
            get
            {
                return _CardOne;
            }
        }
        public int CardTwo
        {
            get
            {
                return _CardTwo;
            }
        }
    }
}
