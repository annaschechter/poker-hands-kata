using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHands;

namespace UnitTestsPokerHands
{
    [TestClass]
    public class UnitTestsCard
    {
        [TestMethod]
        public void CardIsInitializedWithSuitAndValue()
        {
            Card card = new Card("h", "8");
            Assert.AreEqual("h", card.suit);
            Assert.AreEqual("8", card.value);
        }
    }
}
