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

        public void GivePlayerFlush(Player player)
        {
            Card card1 = new Card("d", 14);
            player.TakeCard(card1);
            Card card2 = new Card("d", 5);
            player.TakeCard(card2);
            Card card3 = new Card("d", 12);
            player.TakeCard(card3);
            Card card4 = new Card("d", 8);
            player.TakeCard(card4);
            Card card5 = new Card("d", 10);
            player.TakeCard(card5);
        }
        public void GivePlayerStraight(Player player)
        {
            Card card1 = new Card("d", 14);
            player.TakeCard(card1);
            Card card2 = new Card("h", 13);
            player.TakeCard(card2);
            Card card3 = new Card("h", 12);
            player.TakeCard(card3);
            Card card4 = new Card("d", 11);
            player.TakeCard(card4);
            Card card5 = new Card("d", 10);
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
            Card card = new Card("d", 14);
            anna.TakeCard(card);
            Assert.AreEqual(1, anna.cards.Count);
            Assert.AreEqual("d", anna.cards[0].suit);
            Assert.AreEqual(14, anna.cards[0].value);
        }

        [TestMethod]
        public void PlayerKnowsThatCardsBeenDealt()
        {
            GivePlayerFlush(anna);
            Assert.AreEqual(true, anna.Ready());
        }

        [TestMethod]
        public void PlayerKnowsWhenHasAFlash()
        {
            GivePlayerFlush(anna);
            Assert.AreEqual(true, anna.HasFlush());
        }

        [TestMethod]
        public void PlayerKnowsWhenDoesntHaveAFlush()
        {
            GivePlayerStraight(anna);
            Assert.AreEqual(false, anna.HasFlush());
        }

        [TestMethod]
        public void PlayerKnowsWhenHasAStraight()
        {
            GivePlayerStraight(anna);
            Assert.AreEqual(true, anna.HasStraight());
        }

        [TestMethod]
        public void PlayerKnowsWhenDoesntHaveAStraight()
        {
            GivePlayerFlush(anna);
            Assert.AreEqual(false, anna.HasStraight());
        }

    }
}
