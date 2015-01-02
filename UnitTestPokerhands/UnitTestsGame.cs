using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHands;
using System.Collections.Generic;

namespace UnitTestPokerhands
{
    [TestClass]
    public class UnitTestsGame
    {
        [TestMethod]
        public void GameIsInitializedWithAnEmptyListOfPlayers()
        {
            Game poker = new Game();
            Assert.AreEqual(0, poker.players.Count);
        }
    }
}
