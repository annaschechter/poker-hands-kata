using System;
using System.Collections.Generic;

namespace PokerHands
{
    public class Player
    {
        public List<string> cards { get; set;
        }

        public Player()
        {
            this.cards = new List<string>();
        }

        public void TakeCard(Card card)
        {
            string cardDescription = card.value+card.suit;
            this.cards.Add(cardDescription);
        }

        public bool Ready()
        {
            return this.cards.Count == 5;
        }
    }
}
