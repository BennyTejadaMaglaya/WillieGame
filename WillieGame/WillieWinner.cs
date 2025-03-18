using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillieGame
{
    /// <summary>
    /// Static class to compare two WilieHand Objects and determine the winner
    /// </summary>
    public static class WillieWinner
    {
        /// <summary>
        /// Pass two WillieHand objects
        /// Return value 1 means the first hand won
        /// Return value -1 means the second hand won
        /// Return value 0 means a tie
        /// </summary>
        /// <param name="HandOne">First Hand</param>
        /// <param name="HandTwo">Second Hand</param>
        /// <returns></returns>
        public static int Win(WillieHand HandOne, WillieHand HandTwo)
        {
            if (HandOne.Willie > HandTwo.Willie)
            {
                return 1;
            }
            else if (HandOne.Willie < HandTwo.Willie)
            {
                return -1;
            }
            else //Willie values are tied.
            {
                if (HandOne.Wonka > HandTwo.Wonka)
                {
                    return 1;
                }
                else if (HandOne.Wonka < HandTwo.Wonka)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
