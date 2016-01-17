using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileClass {
    class Program {

        const string path = @"\\Mac\Home\Documents\Code\CoderCamps\FileClass\file.txt";

        static void Main(string[] args) {

            if (File.Exists(path)) {
                string createText = "Oh hello" + Environment.NewLine;
                File.WriteAllText(path, createText);

                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            } else {
                throw new FileLoadException("Could not find file.");
            }
            Console.ReadLine();
        }
    }
}
