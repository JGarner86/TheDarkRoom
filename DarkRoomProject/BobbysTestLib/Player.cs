using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{

    public class Player : Character
    {
        public int ExpPoints { get; set; }
        public int FleeCount { get; set; } = 3;





        public void SwordSlash(Character character)
       {
            int attackAmount = -40;
            StaminaDamageAdjust(ref attackAmount, AttackType.Medium);
           character.Health += attackAmount;
            Console.WriteLine($"{Name} Hit {character.Name} with SwordSlash for{attackAmount}damage");
       }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="character"></param>
       public void FinalSlash (Character character)
       {
            int attackAmount = -80;
            StaminaDamageAdjust(ref attackAmount, AttackType.Heavy);
            Health += attackAmount;
            Console.WriteLine($"{character.Name} Hit {Name} with a FinalSlash for{attackAmount}");
       }


      
       
    }
}
