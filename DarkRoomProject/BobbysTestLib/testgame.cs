﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BobbysTestLib
{
    public class testgame
    {
        


        

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
            


        }
    }    
}
