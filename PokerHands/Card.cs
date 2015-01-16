using System;

namespace PokerHands
{
    public class Card
    {
        public string suit { get; set;
        }
        public int value { get; set;
        }

        public Card(string suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }
    }
}
