using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BobbysTestLib
{
    public class testgame
    {
        public static List<UserInput> TestList = new List<UserInput>();


        public static void whatever()
        {


            UserInput.CheckingPress(GameDialog.LetterL, GameDialog.mainlevel);
            UserInput.CheckingPress(GameDialog.LetterF, GameDialog.deathlevel);
            UserInput.CheckingPress(GameDialog.LetterR, GameDialog.Safe, GameDialog.bearfight, GameDialog.LetterF,GameDialog.secondlevel);
            Console.ReadLine();
            
           
        
        }


        public static void gameover()
        {
            
           

            for (int i = 0; i < 10; i++)
            {
                Console.Beep();
                if (i % 2 == 0)//checks if i is even
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("You died game over");
                    Thread.Sleep(100);
                    Console.Clear();
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You died game over");
                Thread.Sleep(100);
                Console.Clear();
            }   
            Console.Clear();
            whatever();


        }
    }    
}
