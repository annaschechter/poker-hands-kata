using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHands
{
    public class Player
    {
        public List<Card> cards { get; set;
        }

        public Player()
        {
            this.cards = new List<Card>();
        }

        public void TakeCard(Card card)
        {
            this.cards.Add(card);
        }

        public bool Ready()
        {
            return this.cards.Count == 5;
        }

        public bool HasFlush()
        {
            for(int i = 0; i < this.cards.Count - 1; i++)
            {
                Card card = this.cards[i];
                Card nextCard = this.cards[i + 1];
                if(card.suit != nextCard.suit)
                {
                    return false;
                }
            }
            return true;
        }

        public bool HasStraight()
        {
            List<Card> sortedCards = this.cards.OrderBy(card =>card.value).ToList(); 
            for (int i = 0; i < this.cards.Count - 1; i++)
            {
                Card card = sortedCards[i];
                Card nextCard = sortedCards[i + 1];
                if (card.value + 1 != nextCard.value)
                {
                    return false;
                }
            }
            return true;
        }

        public bool HasStraightFlush()
        {
            return (HasFlush() && HasStraight());
        }
    }
}
