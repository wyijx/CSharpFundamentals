using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many rounds do you wish to play? ");
            int rounds = int.Parse(Console.ReadLine());

            PlayGames(rounds);

            Console.ReadLine();
        }

        public static void PlayGames(int numOfRounds) {
            Random choice = new Random();
            Game newGame = new Game();

            Player playerOne;
            Player playerTwo;
            //Console.WriteLine(newGame.TheFight(playerOne, playerTwo));

            //Console.WriteLine("Player {0} uses {1}", playerOne.PlayerNum, playerOne.Act());
            //Console.WriteLine("Player {0} uses {1}", playerTwo.PlayerNum, playerTwo.Act());

            int playerOneWins = 0;
            int playerTwoWins = 0;
            int ties = 0;
            string result;
            int rounds = numOfRounds;

            for (var i = 0; i < rounds; i++) {
                playerOne = new Player(1, choice.Next(3));
                playerTwo = new Player(2, choice.Next(3));

                result = newGame.TheFight(playerOne, playerTwo);
                if (result[7] == '1') {
                    playerOneWins++;
                } else if (result[7] == '2') {
                    playerTwoWins++;
                } else {
                    ties++;
                }
            }
            Console.WriteLine("Ties {0}", ties);
            Console.WriteLine("Player One Wins {0}", playerOneWins);
            Console.WriteLine("Player Two Wins {0}", playerTwoWins);
            Console.WriteLine("/////////////////////");
            if (ties > playerOneWins && ties > playerTwoWins) {
                Console.WriteLine("The Ties have it.");
            } else if (playerOneWins > playerTwoWins) {
                Console.WriteLine("Player One Wins with " + playerOneWins + " rounds!");
            } else {
                Console.WriteLine("Player Two Wins with " + playerTwoWins + " rounds!");
            }
        }
    }
}
