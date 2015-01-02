using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHands;

namespace UnitTestsPokerhands
{
    [TestClass]
    public class UnitTestsPlayer
    {
        private Player anna;

        [TestInitialize]
        public void TestInitialize()
        {
            anna = new Player();
        }

        public void GetPlayerReady(Player player)
        {
            Card card1 = new Card("d", "A");
            player.TakeCard(card1);
            Card card2 = new Card("d", "K");
            player.TakeCard(card2);
            Card card3 = new Card("d", "Q");
            player.TakeCard(card3);
            Card card4 = new Card("d", "J");
            player.TakeCard(card4);
            Card card5 = new Card("d", "T");
            player.TakeCard(card5);
        }

        [TestMethod]
        public void PlayerIsInitializedWithNoCards()
        {
            Assert.AreEqual(0, anna.cards.Count);
        }

        [TestMethod]
        public void PlayerCanTakeCards()
        {
            Card card = new Card("d", "A");
            anna.TakeCard(card);
            Assert.AreEqual(1, anna.cards.Count);
            Assert.AreEqual("Ad", anna.cards[0]);
        }

        [TestMethod]
        public void PlayerKnowsThatCardsBeenDealt()
        {
            GetPlayerReady(anna);
            Assert.AreEqual(true, anna.Ready());
        }

    }
}
