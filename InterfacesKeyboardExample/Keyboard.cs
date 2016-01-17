using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesKeyboardExample {

    interface IKeyboard {
        void PushButton(string buttoToPush);
    }

    class Keyboard : IKeyboard {

        public void PushButton(string buttonToPush) {
            Console.WriteLine(buttonToPush);
        }
    }

    class VirtualKeyboard : IKeyboard {

        public void PushButton(string buttonToPush) {
            foreach (var letter in buttonToPush) {
                Console.Write(letter);
            }
            Console.WriteLine();
        }
    }
}
