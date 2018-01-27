using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{   /// <summary>
    /// Proberites for Weapon Types
    /// </summary>
   public class Weapon:ObtanableItem
    {
        public Weapon()
        {
            
        }
        public int Weight { get; set; }
        public  string Name { get; set; }
        public  bool Breakable { get; set; }
        public  bool Throwable { get; set; }
        public  bool Realoable { get; set; }
        public  int AmmoCount { get; set; }
        public int Timer { get; set; }
        public int Damage { get; set; }
        public int ItemPrice { get; set; }

    }
}
