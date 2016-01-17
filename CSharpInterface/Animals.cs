using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterface {
    public abstract class Animals : IAnimal {

        public string Name { get; set; }
        public string Sound { get; set; }

        public string MakeSound() {
            return Sound;
        }
    }
    
    public class Bear : Animals {
        public Bear() : base() {
            Name = "Bear";
            Sound = "Roar!";
        }
    }

    public class Chicken : Animals, IBird {
        public Chicken() : base() {
            Name = "Chicken";
            Sound = "Bok bok bok!";
        }
    }

    public class Eagle : Animals, IBird {
        public Eagle() : base() {
            Name = "Eagle";
            Sound = "'MURICA";
        }
    }
}

