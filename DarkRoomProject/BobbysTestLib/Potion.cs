using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{   /// <summary>
    /// Propties For Consumable
    /// </summary>
   public class Potion : ObtanableItem
   {
        public int HealingPotion { get; set; }
        public int StamminaPotion { get; set; }
        public int potion { get; set; }
        public int StrengthPotion { get; set; }
        public int DefensePotion { get; set; }


        public Potion(string name)
        {
            Name = name;
            StackableAmount = 10;
        }
       
     
     
    

        
   }
}
