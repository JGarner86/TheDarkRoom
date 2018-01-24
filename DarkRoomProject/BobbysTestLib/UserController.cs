using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    public class UserController
    {
        /// <summary>
        /// 
        /// </summary>
        public static ConsoleKey UserKeyPress { get{ return getKeyPress(); } }
        
        /// <summary>
        /// 
        /// </summary>
        private static List<ConsoleKey> keyMap = new List<ConsoleKey> { ConsoleKey.A, ConsoleKey.S, ConsoleKey.D, ConsoleKey.F, ConsoleKey.G};
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static ConsoleKey getKeyPress()
        {
            ConsoleKey userKey = Console.ReadKey(true).Key;
            while (!keyMap.Contains(userKey))
            {             
                Console.WriteLine("You have entered an invalid key...");
                userKey = Console.ReadKey(true).Key;
            }
            return userKey;
        }
    }
}
