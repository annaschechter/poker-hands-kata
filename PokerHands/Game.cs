using System;
using System.Collections.Generic;
using System.Linq;


namespace PokerHands
{
    public class Game
    {
        public List<Player> players {get; set;
        }

        public Game()
        {
            this.players = new List<Player>();
        }
    }
}
