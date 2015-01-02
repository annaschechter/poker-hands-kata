using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHands;
using System.Collections.Generic;

namespace UnitTestsPokerhands
{
    [TestClass]
    public class UnitTestsGame
    {
        private Game poker;

        [TestInitialize]
        public void TestInitialize()
        {
            poker = new Game();
        }

        [TestMethod]
        public void GameIsInitializedWithAnEmptyListOfPlayers()
        {
            Assert.AreEqual(0, poker.players.Count);
        }

        [TestMethod]
        public void GameKnowsNineHandRankings()
        {
            Assert.AreEqual(9, poker.handRankings.Count);
        }

        [TestMethod]
        public void GameCanAddPlayers()
        {
            Player anna = new Player();
            poker.AddPlayer(anna);
            Assert.AreEqual(1, poker.players.Count);
        }

        [TestMethod]
        public void GameKnowsTheWinner()
        {
            Player anna = new Player();
            Player bob = new Player();
            UnitTestsPlayer.GivePlayerFlush(anna);
            UnitTestsPlayer.GivePlayerStraight(bob);
            poker.AddPlayer(anna);
            poker.AddPlayer(bob);
            Assert.AreEqual(anna, poker.Winner());
            Assert.AreNotEqual(bob, poker.Winner());
        }
    }
}
