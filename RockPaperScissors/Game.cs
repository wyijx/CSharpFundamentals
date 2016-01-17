using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors {
    class Game {

        public string TheFight(Player playerOne, Player playerTwo) {
            if (playerOne.Act() == playerTwo.Act()) {
                return "It's a draw!";
            } else if (playerOne.Act() == "Scissors" && playerTwo.Act() == "Paper") {
                return String.Format("Player {0} wins with {1} against {2}", playerOne.PlayerNum, playerOne.Act(), playerTwo.Act());
            } else if (playerTwo.Act() == "Scissors" && playerOne.Act() == "Paper") {
                return String.Format("Player {0} wins with {1} against {2}", playerTwo.PlayerNum, playerTwo.Act(), playerOne.Act());
            } else if (playerOne.Act() == "Rock" && playerTwo.Act() == "Scissors") {
                return String.Format("Player {0} wins with {1} against {2}", playerOne.PlayerNum, playerOne.Act(), playerTwo.Act());
            } else if (playerTwo.Act() == "Rock" && playerOne.Act() == "Scissors") {
                return String.Format("Player {0} wins with {1} against {2}", playerTwo.PlayerNum, playerTwo.Act(), playerOne.Act());
            } else if (playerOne.Act() == "Paper" && playerTwo.Act() == "Rock") {
                return String.Format("Player {0} wins with {1} against {2}", playerOne.PlayerNum, playerOne.Act(), playerTwo.Act());
            } else {
                return String.Format("Player {0} wins with {1} against {2}", playerTwo.PlayerNum, playerTwo.Act(), playerOne.Act());
            } 
        }
    }
}
