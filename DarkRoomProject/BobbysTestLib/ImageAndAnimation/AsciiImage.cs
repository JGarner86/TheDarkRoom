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
        public int NextPixel { get; set; }

        public AsciiImage(Point[] _point, ConsoleColor[] _pixelBackgroundColor, ConsoleColor[] _pixelForegroundColor, char[] _distanceChar)
        {
            Cooridinate = _point;
            PixelBackgroundColor = _pixelBackgroundColor;
            PixelForegroundColor = _pixelForegroundColor;
            DistanceChar = _distanceChar;
            
        }

        public void PrintImage()
        {
            for (int i = 0; i < Cooridinate.Length; i++)
            {
                Console.SetCursorPosition(Cooridinate[i].X,Cooridinate[i].Y);
                Console.BackgroundColor = PixelBackgroundColor[i];
                Console.ForegroundColor = PixelForegroundColor[i];
                Console.Write(DistanceChar[i]);
            }
            Console.ResetColor();
        }

        public void PrintImage(Point referencePoint)
        {
            for (int i = 0; i < Cooridinate.Length; i++)
            {
                int newX = referencePoint.X + Cooridinate[i].X;
                int newY = referencePoint.Y + Cooridinate[i].Y;
                Console.SetCursorPosition(newX, newY);
                Console.BackgroundColor = PixelBackgroundColor[i];
                Console.ForegroundColor = PixelForegroundColor[i];
                Console.Write(DistanceChar[i]);
            }
            Console.ResetColor();
        }


    }
}
