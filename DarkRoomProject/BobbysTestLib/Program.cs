using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using System.Threading;
using System.Diagnostics;

namespace BobbysTestLib
{
    class Program
    {

        

        static void Main(string[] args)
        {

            //HudModule.HudStatusBar.Preview();
            //ArtModule.PrintAsciiFile();

            Stopwatch watch = new Stopwatch();
            
            ImageAndAnimation.AsciiImage fireImage = ImageAndAnimation.ImageProcessor.BuildAsciiImage(@"D:\Google Drive\WPF\TheDarkRoom\TheDarkRoom\DarkRoomProject\AsciiArt\Fire\SplitImages\tmp-0.gif");
            watch.Start();
            fireImage.PrintImage();
            watch.Stop();
            Console.WriteLine();
            Console.WriteLine($"Time: {watch.Elapsed}");
            
            Console.WriteLine("Start Original code");
            Console.WriteLine();
            watch.Restart();
            ArtModule.PrintPic();
            watch.Stop();
            Console.WriteLine($"Time: {watch.Elapsed}");
            Console.ReadLine();


        }

    }


}
    

