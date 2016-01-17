using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesKeyboardExample {
    class Program {
        static void Main(string[] args) {

            PushTheSpaceBar(new VirtualKeyboard());
            PushTheSpaceBar(new Keyboard());

            Console.ReadLine();
        }
        static void PushTheSpaceBar(IKeyboard keyboard) {
            keyboard.PushButton("toodledoo."); 
        }
    }
}
