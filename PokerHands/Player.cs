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

        public bool HasFlash()
        {

            for(int i = 0; i < this.cards.Count - 1; i++)
            {
                string card = this.cards[i];
                string nextCard = this.cards[i + 1];
                if(card[card.Length - 1] != nextCard[nextCard.Length - 1])
                {
                    return false;
                }

            }
            return true;
        }
    }
}
