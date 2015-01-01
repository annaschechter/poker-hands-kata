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
            Assert.AreEqual(0, player.cards.Count);
        }

        [TestMethod]
        public void PlayerCanTakeCards()
        {
            Player player = new Player();
            Card card = new Card("d", "A");
            player.TakeCard(card);
            Assert.AreEqual(1, player.cards.Count);
            Assert.AreEqual("dA", player.cards[0]);
        }

    }
}
