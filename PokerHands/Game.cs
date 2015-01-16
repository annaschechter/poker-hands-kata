using System;
using System.Collections.Generic;
using System.Linq;


namespace PokerHands
{
    public class Game
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the name of the first player:");
            string player1Name = Console.ReadLine();
            Player player1 = new Player();
            Console.WriteLine("Please enter the name of the second player:");
            string player2Name = Console.ReadLine();
            Player player2 = new Player();
            Game poker = new Game();
            poker.AddPlayer(player1);
            poker.AddPlayer(player2);

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Please enter the card suit for " + player1Name + " choose from 'h', 'd', 's' or 'c'");
                string suit = Console.ReadLine();
                Console.WriteLine("Please enter the card value for " + player1Name + " choose from numbers 2 to 14");
                int value = Convert.ToInt16(Console.ReadLine());
                Card player1Card = new Card(suit, value);
                player1.TakeCard(player1Card);
            }

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Please enter the card suit for " + player2Name + " choose from 'h', 'd', 's' or 'c'");
                string suit = Console.ReadLine();
                Console.WriteLine("Please enter the card value for " + player2Name + " choose from numbers 2 to 14");
                int value = Convert.ToInt16(Console.ReadLine());
                Card player2Card = new Card(suit, value);
                player2.TakeCard(player2Card);
            }

            Player winner = poker.Winner();
            if (winner == player1)
            {
                string winnerName = player1Name;
                Console.WriteLine("The winner is " + winnerName);
            }
            else
            {
                string winnerName = player2Name;
                Console.WriteLine("The winner is " + winnerName);
            }
            Console.WriteLine("Hope you enjoyed the game!!!");
            Console.ReadLine();

        }

        
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
