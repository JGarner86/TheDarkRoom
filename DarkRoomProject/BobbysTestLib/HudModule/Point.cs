using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib.HudModule
{   
    
    class Point
    {
        /// <summary>
        /// The X coordinate specified on the console
        /// </summary>
        public int X { get; }
        
        /// <summary>
        /// The Y coordinate specified on the console
        /// </summary>
        public int Y { get; }

        /// <summary>
        /// Constructor for the Point object, creates a x,y coordinate to place Hud elements on the console
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
    }
}
