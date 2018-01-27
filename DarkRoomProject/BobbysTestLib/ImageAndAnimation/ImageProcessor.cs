using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BobbysTestLib.ImageAndAnimation
{
    class ImageProcessor
    {
        static int[] cColors = { 0x000000, 0x000080, 0x008000, 0x008080, 0x800000, 0x800080, 0x808000,
            0xC0C0C0, 0x808080, 0x0000FF, 0x00FF00, 0x00FFFF, 0xFF0000, 0xFF00FF, 0xFFFF00, 0xFFFFFF };

        

        private static void GetPixelData(Color cValue, ref AsciiImage image)
        {
           

            Color[] cTable = cColors.Select(x => Color.FromArgb(x)).ToArray();
            char[] rList = new char[] { (char)9617, (char)9618, (char)9619, (char)9608 }; // 1/4, 2/4, 3/4, 4/4
            int[] bestHit = new int[] { 0, 0, 4, int.MaxValue }; //ForeColor, BackColor, Symbol, Score

            for (int rChar = rList.Length; rChar > 0; rChar--)
            {
                for (int cFore = 0; cFore < cTable.Length; cFore++)
                {
                    for (int cBack = 0; cBack < cTable.Length; cBack++)
                    {
                        int R = (cTable[cFore].R * rChar + cTable[cBack].R * (rList.Length - rChar)) / rList.Length;
                        int G = (cTable[cFore].G * rChar + cTable[cBack].G * (rList.Length - rChar)) / rList.Length;
                        int B = (cTable[cFore].B * rChar + cTable[cBack].B * (rList.Length - rChar)) / rList.Length;
                        int iScore = (cValue.R - R) * (cValue.R - R) + (cValue.G - G) * (cValue.G - G) + (cValue.B - B) * (cValue.B - B);
                        if (!(rChar > 1 && rChar < 4 && iScore > 50000)) // rule out too weird combinations
                        {
                            if (iScore < bestHit[3])
                            {
                                bestHit[3] = iScore; //Score
                                bestHit[0] = cFore;  //ForeColor
                                bestHit[1] = cBack;  //BackColor
                                bestHit[2] = rChar;  //Symbol
                            }
                        }
                    }
                }
            }
            image.PixelForegroundColor[image.NextPixel] = (ConsoleColor)bestHit[0];
            image.PixelBackgroundColor[image.NextPixel] = (ConsoleColor)bestHit[1];
            image.DistanceChar[image.NextPixel] = rList[bestHit[2] - 1];
        }

        public static AsciiImage BuildAsciiImage(string path)
        {

            Bitmap source = new Bitmap(path, true);
            int sMax = 39;
            decimal percent = Math.Min(decimal.Divide(sMax, source.Width), decimal.Divide(sMax, source.Height));
            Size dSize = new Size((int)(source.Width * percent), (int)(source.Height * percent));
            Bitmap bmpMax = new Bitmap(source, dSize.Width * 2, dSize.Height);
            int size = (dSize.Width * 2) * dSize.Height;
            AsciiImage image = new AsciiImage(new Point[size], new ConsoleColor[size], new ConsoleColor[size], new char[size]);
            int nextPixel = 0;
            int nextX = 0;
            for (int i = 0; i < dSize.Height; i++)
            {
                for (int j = 0; j < dSize.Width; j++)
                {
                    image.NextPixel = nextPixel;
                    image.Cooridinate[nextPixel] = new Point(nextX, i);
                    GetPixelData(bmpMax.GetPixel(j * 2, i), ref image);

                    nextPixel++;
                    image.NextPixel = nextPixel;
                    nextX++;
                    image.Cooridinate[nextPixel] = new Point(nextX, i);
                    GetPixelData(bmpMax.GetPixel(j * 2 + 1, i), ref image);

                    nextPixel++;
                    nextX++;
                }
                nextX = 0;
                //Console.WriteLine();
            }
            //Console.ResetColor();
            return image;
        }
    }
}
