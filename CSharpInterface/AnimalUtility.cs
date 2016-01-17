using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterface {
    class AnimalUtility {
        public static string DoSomething(Animals animal) {

            if (animal is IBird) {
                return String.Format("Flap, Flap, Flap " + animal.MakeSound());
            } else {
                return animal.MakeSound();
            }
        }
    }
}
