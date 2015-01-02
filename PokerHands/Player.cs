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

        public bool HasFourOfAKind()
        {
            for (int i = 0; i < this.cards.Count; i++)
            {
                int value = this.cards[i].value;
                if (this.cards.FindAll(card => card.value.Equals(value)).Count == 4)
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasThreeOfAKind()
        {
            for (int i = 0; i < this.cards.Count; i++)
            {
                int value = this.cards[i].value;
                if (this.cards.FindAll(card => card.value.Equals(value)).Count == 3)
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasAPair()
        {
            List<int> matches = new List<int>();
            for (int i = 0; i < this.cards.Count; i++)
            {
                int value = this.cards[i].value;
                matches.Add(this.cards.FindAll(card => card.value.Equals(value)).Count);
            }
            return (matches.FindAll(number => number.Equals(2)).Count == 2);
        }

        public bool HasTwoPair()
        {
            List<int> matches = new List<int>();
            for (int i = 0; i < this.cards.Count; i++)
            {
                int value = this.cards[i].value;
                matches.Add(this.cards.FindAll(card => card.value.Equals(value)).Count);
            }
            return (matches.FindAll(number => number.Equals(2)).Count == 4);
        }

        public bool HasFullHouse()
        {
            return (HasThreeOfAKind() && HasAPair());
        }

        public string Hand()
        {
            if (HasStraightFlush()) return "straight flush";
            if (HasFourOfAKind()) return "four of a kind";
            if (HasFullHouse()) return "full house";
            if (HasFlush()) return "flush";
            if (HasStraight()) return "straight";
            if (HasThreeOfAKind()) return "three of a kind";
            if (HasTwoPair()) return "two pair";
            if (HasAPair()) return "a pair";
            return "high card";

        }
    }
}
