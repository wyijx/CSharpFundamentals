using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;

namespace PlayMovieQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            playSimpleSound(rnd.Next(3));
            Console.ReadLine();
        }
        public static void playSimpleSound(int value) {
            var sounds = new SoundPlayer[] {
            new SoundPlayer(@"\\Mac\Home\Documents\Code\CoderCamps\PlayMovieQuotes\t2_learning_computer_x.wav"),
            new SoundPlayer(@"\\Mac\Home\Documents\Code\CoderCamps\PlayMovieQuotes\tumor.wav"),
            new SoundPlayer(@"\\Mac\Home\Documents\Code\CoderCamps\PlayMovieQuotes\punk.wav")
            };

            sounds[value].Play();
        }
    }
}
