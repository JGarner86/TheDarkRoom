using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    public class Player : Character
    { /// <summary>
    /// 
    /// </summary>
    /// <param name="character"></param>
       public void SwordSlash(Character character)
       {
            int attackAmount = -40;
            StaminaDamageAdjust(ref attackAmount, AttackType.Medium);
           character.Health += attackAmount;
            Console.WriteLine($"{Name} Hit {character.Name} with swordSlash for{attackAmount}damage");
       }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="character"></param>
       public void HeavyAttack(Character character)
       {
            int attackAmount = -80;
            StaminaDamageAdjust(ref attackAmount, AttackType.Heavy);
            Health += attackAmount;
            Console.WriteLine($"{character.Name} Hit {Name} with a Heavy attack for{attackAmount}");
       }


      
       
    }
}
