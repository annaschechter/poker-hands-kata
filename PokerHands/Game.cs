using System;
using System.Collections.Generic;
using System.Linq;


namespace PokerHands
{
    public class Game
    {
        public List<Player> players {get; set;
        }
        public Dictionary<string, int> handRankings { get; set;
        }

        public Game()
        {
            this.players = new List<Player>();
            this.handRankings = new Dictionary<string, int>();
            handRankings.Add("straight flush", 1);
            handRankings.Add("four of a kind", 2);
            handRankings.Add("full house", 3);
            handRankings.Add("flush", 4);
            handRankings.Add("straight", 5);
            handRankings.Add("three of a kind", 6);
            handRankings.Add("two pair", 7);
            handRankings.Add("a pair", 8);
            handRankings.Add("high card", 9);
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public Player Winner()
        {
            Player winner = this.players[0]; 
            for (int i = 0; i < this.players.Count; i++)
            {
                Player currentPlayer = this.players[i];
                string playersHand = this.players[i].Hand();
                if (this.handRankings[playersHand] < this.handRankings[winner.Hand()]) 
                {
                    winner = currentPlayer;
                }
                else if (this.handRankings[playersHand] == this.handRankings[winner.Hand()])
                {
                    winner = _EqualHandRankings(currentPlayer, winner);
                }
            }
            return winner;
        }

        private Player _EqualHandRankings(Player player1, Player player2)
        {
            return player1.winningCard.value> player2.winningCard.value ? player1 : player2;
        }
    }
}
