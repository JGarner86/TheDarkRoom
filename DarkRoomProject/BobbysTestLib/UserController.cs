using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    public class UserController
    {
        public static ConsoleKey UserKeyPress { get{ return getKeyPress(); } }

        private static List<ConsoleKey> keyMap = new List<ConsoleKey> { ConsoleKey.R, ConsoleKey.H, ConsoleKey.F };
        //private static ConsoleKey userKey = getKeyPress();
        private static ConsoleKey getKeyPress()
        {

            ConsoleKey userKey = Console.ReadKey().Key;
            if (!keyMap.Contains(userKey))
            {
                Console.WriteLine("You have entered an invalid key...");
                
                getKeyPress();
               
            }
            return userKey;
        }
    }
}
