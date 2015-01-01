using System;

namespace PokerHands
{
    public class Card
    {
        public string suit { get; set;
        }
        public string value { get; set;
        }

        public Card(string suit, string value)
        {
            this.suit = suit;
            this.value = value;
        }

        public static void Main()
        { 
        }
    }
}
