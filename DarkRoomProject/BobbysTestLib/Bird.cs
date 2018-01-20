using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    public class Bird : Animal
    {
        public static string BaseSpeak { get; private set; }  = "Chirp, Chirp!";
        public int Legs { get; } = 2;

        
    }
}
