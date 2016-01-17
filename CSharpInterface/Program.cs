using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterface {
    class Program {
        static void Main(string[] args) {
            var bear = new Bear();
            var eagle = new Eagle();
            var chicken = new Chicken();

            Console.WriteLine(AnimalUtility.DoSomething(bear));
            Console.WriteLine(AnimalUtility.DoSomething(eagle));
            Console.WriteLine(AnimalUtility.DoSomething(chicken));

            Console.ReadLine();
        }
    }
}
