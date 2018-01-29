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

          
            string artPath = @"D:\Google Drive\WPF\TheDarkRoom\TheDarkRoom\DarkRoomProject\AsciiArt\";
            string goblin = @"\Goblin\GoblinPixel 0.jpg";

            ImageAndAnimation.AsciiImage gblnJpeg = ImageAndAnimation.ImageProcessor.BuildAsciiImage($"{artPath}{goblin}");
            ImageAndAnimation.AsciiImage gblnOriginal = ImageAndAnimation.ImageProcessor.BuildAsciiImage($"{artPath}" + @"\ChestGif\ChestPixelated\PixJpg\ChestPixel 0.jpg");

            Console.WriteLine("Original Image");
            gblnOriginal.PrintImage();
            Console.WriteLine();
            Console.WriteLine("Pre-Pixelated Image");
            gblnJpeg.PrintImage();
           
            
        

         
        
            Console.ReadLine();


        }

    }


}
    

