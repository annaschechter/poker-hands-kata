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
            Card myCard = new Card("h", 8);
            Assert.AreEqual("h", myCard.suit);
            Assert.AreEqual(8, myCard.value);
        }
    }
}
