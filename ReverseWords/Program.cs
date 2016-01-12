using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            var userInput = Console.ReadLine();

            var reversed = ReverseWords(userInput);
            Console.WriteLine("In Reverse {0}", reversed);
            
            //pause
            Console.ReadLine();
         }
        public static string ReverseWords(string s)
        {   
            //This works by calling String.Join and providing to it the argument string
            //modified by the Methods .Split and then .Reverse, then conforms it to a String.
            return String.Join(" ", s.Split('.', ' ').Reverse()).ToString();
        }
    }
}
