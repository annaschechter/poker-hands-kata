using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHands;

namespace UnitTestsPokerhands
{
    [TestClass]
    public class UnitTestsPlayer
    {
        [TestMethod]
        public void PlayerIsInitializedWithNoCards()
        {
            Player player = new Player();
            Assert.AreEqual(0, player.cards.Length);
        }

    }
}
