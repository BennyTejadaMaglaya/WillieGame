using Microsoft.VisualStudio.TestTools.UnitTesting;
using WillieGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillieGame.Tests
{
    [TestClass()]
    public class WillieWinnerTests
    {
        #region Exercise 2 - Part C

        /// <summary>
        /// Ex2 UseCase C1 Ace,King .vs. Jack,7 - Winner -1
        /// </summary>
        [TestMethod()]
        public void WinTestC1()
        {
            //Arrange
            WillieHand HandOne = new WillieHand(1, 13);
            WillieHand HandTwo = new WillieHand(11, 7);
            int expected = -1;

            //Act
            int actual = WillieWinner.Win(HandOne, HandTwo);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ex2 UseCase C2 Ace,King .vs. 6,4 - Winner 1
        /// </summary>
        [TestMethod()]
        public void WinTestC2()
        {
            //Arrange
            WillieHand HandOne = new WillieHand(1, 13);
            WillieHand HandTwo = new WillieHand(6, 4);
            int expected = 1;

            //Act
            int actual = WillieWinner.Win(HandOne, HandTwo);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ex2 UseCase C3 Ace,King .vs. Queen,Ace - Winner 1
        /// </summary>
        [TestMethod()]
        public void WinTestC3()
        {
            //Arrange
            WillieHand HandOne = new WillieHand(1, 13);
            WillieHand HandTwo = new WillieHand(12, 1);
            int expected = 1;

            //Act
            int actual = WillieWinner.Win(HandOne, HandTwo);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ex2 UseCase C4 6,5 .vs. Ace,King - Winner -1
        /// </summary>
        [TestMethod()]
        public void WinTestC4()
        {
            //Arrange
            WillieHand HandOne = new WillieHand(6, 5);
            WillieHand HandTwo = new WillieHand(1, 13);
            int expected = -1;

            //Act
            int actual = WillieWinner.Win(HandOne, HandTwo);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Ex2 UseCase C5 Jack,10 .vs. 10,Jack - Winner 0
        /// </summary>
        [TestMethod()]
        public void WinTestC5()
        {
            //Arrange
            WillieHand HandOne = new WillieHand(11, 10);
            WillieHand HandTwo = new WillieHand(10, 11);
            int expected = 0;

            //Act
            int actual = WillieWinner.Win(HandOne, HandTwo);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UseCase C6 King,10 .vs. Queen,King - Winner 0
        /// Example of a tie with hands that are not just a mirror image
        /// </summary>
        [TestMethod()]
        public void WinTestC6()
        {
            //Arrange
            WillieHand HandOne = new WillieHand(13, 10);
            WillieHand HandTwo = new WillieHand(12, 13);
            int expected = 0;

            //Act
            int actual = WillieWinner.Win(HandOne, HandTwo);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        #endregion
    }
}