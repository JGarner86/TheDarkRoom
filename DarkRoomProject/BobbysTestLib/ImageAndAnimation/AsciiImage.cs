using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib.ImageAndAnimation
{
    public class AsciiImage
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public Point[] Cooridinate { get; set; }
        public ConsoleColor[] PixelBackgroundColor { get; set; }
        public ConsoleColor[] PixelForegroundColor { get; set; }
        public char[] DistanceChar { get; set; }
        public int Size { get; set; }

        public AsciiImage(Point[] _point, ConsoleColor[] _pixelBackgroundColor, ConsoleColor[] _pixelForegroundColor, char[] _distanceChar)
        {
            Cooridinate = _point;
            PixelBackgroundColor = _pixelBackgroundColor;
            PixelForegroundColor = _pixelForegroundColor;
            DistanceChar = _distanceChar;
            
        }


    }
}
