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
    public class WillieHandTests
    {
        /// <summary>
        /// Use Case A1- Nine and jack, Expect Willie of 19
        /// </summary>
        [TestMethod()]
        public void WillieHandTestA1()
        {
            //Arrange
            int card1 = 9;
            int card2 = 11;
            WillieHand target = new WillieHand(card1, card2);
            int expected = 19;

            //Act
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}