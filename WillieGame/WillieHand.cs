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
        public const string CardValueTooLowMessage = "Invalid Card value - too low";
        public const string CardValueTooHighMessage = "Invalid Card value - too high";

        /// <summary>
        /// Pass the integer values of the cards as you construct the hand
        /// </summary>
        /// <param name="CardOne">First card in the Willie hand</param>
        /// <param name="CardTwo">Second card in the Willie hand</param>
        public WillieHand(int CardOne, int? CardTwo)
        {
            _CardOne = CardOne;
            _CardTwo = CardTwo.GetValueOrDefault();
            if (_CardOne > 13)
            {
                throw new System.ArgumentOutOfRangeException("Card One", _CardOne, CardValueTooHighMessage);
            }
            else if (_CardTwo > 13)
            {
                throw new System.ArgumentOutOfRangeException("Card Two", _CardTwo, CardValueTooHighMessage);
            }
            else if (_CardOne < 1)
            {
                throw new System.ArgumentOutOfRangeException("Card One", _CardOne, CardValueTooLowMessage);
            }
            else if (_CardTwo < 0)
            {
                throw new System.ArgumentOutOfRangeException("Card Two", _CardTwo, CardValueTooLowMessage);
            }
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
