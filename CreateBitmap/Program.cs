using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateBitmap {
    class Program {
        static void Main(string[] args) {
            using (var bitmap = new Bitmap(500, 500)) {

                var rnd = new Random();
                for (var i = 0; i < 500; i++) {
                    for (var k = 0; k < 500; k++) {
                        bitmap.SetPixel(i, k, Color.Black);
                    }
                }
                for(var i = 0; i < 500; i++) {
                    bitmap.SetPixel(i, 250, Color.White);
                }

                var currentDirectory = Environment.CurrentDirectory;
                var path = Path.Combine(currentDirectory, "Myverticalline.png");
                bitmap.Save(path, ImageFormat.Png);
            }
        }
    }
}
