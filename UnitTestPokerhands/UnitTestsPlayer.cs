﻿using System;
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

        public static void GivePlayerFlush(Player player)
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
        public static void GivePlayerStraight(Player player)
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
        public static void GivePlayerStraightFlush(Player player)
        {
            Card card1 = new Card("h", 14);
            player.TakeCard(card1);
            Card card2 = new Card("h", 13);
            player.TakeCard(card2);
            Card card3 = new Card("h", 12);
            player.TakeCard(card3);
            Card card4 = new Card("h", 11);
            player.TakeCard(card4);
            Card card5 = new Card("h", 10);
            player.TakeCard(card5);
        }
        public static void GivePlayerFourOfAKind(Player player)
        {
            Card card1 = new Card("h", 9);
            player.TakeCard(card1);
            Card card2 = new Card("c", 5);
            player.TakeCard(card2);
            Card card3 = new Card("h", 9);
            player.TakeCard(card3);
            Card card4 = new Card("d", 9);
            player.TakeCard(card4);
            Card card5 = new Card("s", 9);
            player.TakeCard(card5);
        }
        public static void GivePlayerThreeOfAKind(Player player)
        {
            Card card1 = new Card("h", 2);
            player.TakeCard(card1);
            Card card2 = new Card("c", 9);
            player.TakeCard(card2);
            Card card3 = new Card("h", 11);
            player.TakeCard(card3);
            Card card4 = new Card("d", 9);
            player.TakeCard(card4);
            Card card5 = new Card("s", 9);
            player.TakeCard(card5);
        }
        public static void GivePlayerAPair(Player player)
        {
            Card card1 = new Card("h", 2);
            player.TakeCard(card1);
            Card card2 = new Card("c", 2);
            player.TakeCard(card2);
            Card card3 = new Card("h", 11);
            player.TakeCard(card3);
            Card card4 = new Card("d", 8);
            player.TakeCard(card4);
            Card card5 = new Card("s", 13);
            player.TakeCard(card5);
        }

        public static void GivePlayerTwoPair(Player player)
        {
            Card card1 = new Card("h", 2);
            player.TakeCard(card1);
            Card card2 = new Card("c", 2);
            player.TakeCard(card2);
            Card card3 = new Card("h", 11);
            player.TakeCard(card3);
            Card card4 = new Card("d", 11);
            player.TakeCard(card4);
            Card card5 = new Card("s", 4);
            player.TakeCard(card5);
        }
        public static void GivePlayerFullHouse(Player player)
        {
            Card card1 = new Card("h", 2);
            player.TakeCard(card1);
            Card card2 = new Card("c", 2);
            player.TakeCard(card2);
            Card card3 = new Card("h", 11);
            player.TakeCard(card3);
            Card card4 = new Card("d", 11);
            player.TakeCard(card4);
            Card card5 = new Card("s", 11);
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

        [TestMethod]
        public void PlayerKnowsWhenHasAStraightFlush()
        {
            GivePlayerStraightFlush(anna);
            Assert.AreEqual(true, anna.HasStraightFlush());

        }

        [TestMethod]
        public void PlayerKnowsWhenDoesntHaveAStraightFlush()
        {
            GivePlayerFlush(anna);
            Assert.AreEqual(false, anna.HasStraightFlush());
        }

        [TestMethod]
        public void PlayerKnowsWhenHasFourOfAKind()
        {
            GivePlayerFourOfAKind(anna);
            Assert.AreEqual(true, anna.HasFourOfAKind());
        }

        [TestMethod]
        public void PlayerKnowsWhenDoesntHaveFourOfAKind()
        {
            GivePlayerStraight(anna);
            Assert.AreEqual(false, anna.HasFourOfAKind());
        }

        [TestMethod]
        public void PlayerKnowsWhenHasThreeOfAKind()
        {
            GivePlayerThreeOfAKind(anna);
            Assert.AreEqual(true, anna.HasThreeOfAKind());
        }

        [TestMethod]
        public void PlayerKnowsWhenDoesntHaveThreeOfAKind()
        {
            GivePlayerStraight(anna);
            Assert.AreEqual(false, anna.HasThreeOfAKind());
        }

        [TestMethod]
        public void PlayerKnowsWhenHasAPair()
        {
            GivePlayerAPair(anna);
            Assert.AreEqual(true, anna.HasAPair());
        }
        [TestMethod]
        public void PlayerKnowsWhenDoesntHaveAPair()
        {
            GivePlayerThreeOfAKind(anna);
            Assert.AreEqual(false, anna.HasAPair());
        }

        [TestMethod]
        public void PlayerKnowsWhenHasTwoPair()
        {
            GivePlayerTwoPair(anna);
            Assert.AreEqual(true, anna.HasTwoPair());
        }

        [TestMethod]
        public void PlayerKnowsWhenDoesntHaveTwoPair()
        {
            GivePlayerFourOfAKind(anna);
            Assert.AreEqual(false, anna.HasTwoPair());
        }

        [TestMethod]
        public void PlayerKnowsWhenHasFullHouse()
        {
            GivePlayerFullHouse(anna);
            Assert.AreEqual(true, anna.HasFullHouse());
        }

        [TestMethod]
        public void PlayerKnowsWhenDoesntHaveFullHouse()
        {
            GivePlayerThreeOfAKind(anna);
            Assert.AreEqual(false, anna.HasFullHouse());
        }

        [TestMethod]
        public void PlayerKnowsWhatHandTheyHaveFullHouse()
        {
            GivePlayerFullHouse(anna);
            Assert.AreEqual("full house", anna.Hand());
        }

        [TestMethod]
        public void PlayerKnowsWhatHandTheyHaveAPair()
        {
            GivePlayerAPair(anna);
            Assert.AreEqual("a pair", anna.Hand());
        }

        [TestMethod]
        public void PlayerKnowsWhatHandTheyHaveStraight()
        {
            GivePlayerStraight(anna);
            Assert.AreEqual("straight", anna.Hand());
        }

    }
}
