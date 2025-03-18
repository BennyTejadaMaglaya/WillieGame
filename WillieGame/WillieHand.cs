namespace WillieGame
{
    /// <summary>
    /// Class to represent a Hand in the card game Willie
    /// </summary>
    public partial class WillieHand
    {
        private int _CardOne;
        private int _CardTwo;
        private int _Willie;

        /// <summary>
        /// Pass the integer values of the cards as you construct the hand
        /// </summary>
        /// <param name="CardOne">First card in the Willie hand</param>
        /// <param name="CardTwo">Second card in the Willie hand</param>
        public WillieHand(int CardOne, int CardTwo)
        {
            _CardOne = CardOne;
            _CardTwo = CardTwo;
        }

        /// <summary>
        /// Willie value of the hand
        /// </summary>
        public int Willie
        {
            get
            {
                if (_CardOne > 10)
                    _Willie = 10;
                else _Willie = _CardOne;
                if (_CardTwo > 10)
                    _Willie += 10;
                else _Willie += _CardTwo;
                return _Willie;
            }
        }

        /// <summary>
        /// Actual value of the first hand
        /// </summary>
        public int CardOne
        {
            get
            {
                return _CardOne;
            }
        }

        /// <summary>
        /// Actual value of the second hand
        /// </summary>
        public int CardTwo
        {
            get
            {
                return _CardTwo;
            }
        }
    }
}
