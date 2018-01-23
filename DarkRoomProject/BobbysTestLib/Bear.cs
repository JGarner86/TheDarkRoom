using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
   public class Bear:Character
    {
        
        public void ClawSlash(Bear bear, Player player)
        {
            int attackAmount = -30;
            DamageAdjust(ref attackAmount);
            player.Health += attackAmount;
            Console.WriteLine($" { bear.Name} Hit { player.Name} with a claw slash For {attackAmount} Damage ");
   
        }


        public void HeavySlash(Bear bear, Player player)
        {
            int attackAmount = -60;
            DamageAdjust(ref attackAmount);
            player.Health += attackAmount;
            Console.WriteLine($"{bear.Name} Hit {player.Name} with a HeavySlash for {attackAmount}");
        }

        

        public void PowerUp(Bear bear)
        {
            int defenseUp = 40;
            bear.Health += defenseUp;
            Console.WriteLine($"{bear.Name} used agro to Power Up {defenseUp}");
        }
        
    }
}
