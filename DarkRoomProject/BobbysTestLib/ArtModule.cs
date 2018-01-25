using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace BobbysTestLib
{
    public class ArtModule
    {
        /// <summary>
        /// Prints ascii file to console.
        /// </summary>
        public static void PrintAsciiFile()
        {
            try
            {
                //D:\Google Drive\WPF\TheDarkRoom\TheDarkRoom\DarkRoomProject\BobbysTestLib
                string path = @"~\AsciiArt\Test.txt";
                using (StreamReader streamReader = new StreamReader(path))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.WriteLine(GetArtPath());
            
        }

        private static string GetArtPath()
        {
            string path = Assembly.GetEntryAssembly().CodeBase;
            return path;
        }
    }
}
