using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors {
    class Player {
        private string _hand { get; set; }
        public int PlayerNum { get; set; }

        public Player(int num, int rnd) {
            PlayerNum = num;
            _hand = ChooseWeapon(rnd);
        }

        public string ChooseWeapon(int rnd) {
            var weapons = new string[] {
                "Rock", "Paper", "Scissors"
            };

            return weapons[rnd];
        }
        public string Act() {
            return _hand;
        }
    }
}
