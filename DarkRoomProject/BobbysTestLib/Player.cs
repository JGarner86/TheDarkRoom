using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    public class Player : Character
    {
       public void SwordSlash(Player player, Bear bear)
       {
            int attackAmount = -40;
            DamageAdjust(ref attackAmount);
            bear.Health += attackAmount;
            Console.WriteLine($"{player.Name} Hit {bear.Name} with swordSlash for{attackAmount}damage");
       }


       public void HeavyAttack(Player player, Bear bear)
       {
            int attackAmount = -80;
            DamageAdjust(ref attackAmount);
            bear.Health += attackAmount;
            Console.WriteLine($"{player.Name} Hit {bear.Name} with a Heavy attack for{attackAmount}");
       }


      public  void Healing(Player player)
      {
            int potion = 100;
            player.Health += potion;
            Console.WriteLine($"{player.Name} Drinks a Potion and gains {potion} health");

      } 
       
    }
}
