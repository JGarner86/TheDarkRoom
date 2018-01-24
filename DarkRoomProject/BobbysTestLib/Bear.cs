using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    public class Bear : Character
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
        public void Main()
        {
            List<Bear> enemies = new List<Bear>();
            Player Jack = new Player();

            enemies.Add(new Bear() { Name = "Tiger", Health = 100, Stamina = 70  }  );

            enemies.Add(new Bear() { Name = "Gorilla", Health = 200, Stamina = 60 } );

            enemies.Add(new Bear()
            {
                Name = "VampireBat",
                Health = 50,
                Stamina = 100,
                PrimaryWeapon = new Weapon() {Name = "Scream", Damage = -30}
            });
            
            enemies.Add(new Bear() { Name = "Goblin",
                                     Health = 150,
                                     Stamina = 50  } );
            enemies.Add(new Bear() { Name = "Troll",
                                     Health = 200,
                                     Stamina = 30} );
            PrimaryWeaponAttack(enemies[2], Jack, FromTo.BearToPlayer);
            PrimaryWeaponAttack(enemies[2], Jack, FromTo.PlayerToBear);
            PrimaryWeaponAttack(enemies[0], Jack, FromTo.BearToPlayer);
            PrimaryWeaponAttack(enemies[0], Jack, FromTo.PlayerToBear);
            PrimaryWeaponAttack(enemies[1], Jack, FromTo.BearToPlayer);
            PrimaryWeaponAttack(enemies[1], Jack, FromTo.PlayerToBear);
            PrimaryWeaponAttack(enemies[3], Jack, FromTo.BearToPlayer);
            PrimaryWeaponAttack(enemies[3], Jack, FromTo.PlayerToBear);
            PrimaryWeaponAttack(enemies[4], Jack, FromTo.BearToPlayer);
            PrimaryWeaponAttack(enemies[4], Jack, FromTo.PlayerToBear);
            
            Console.WriteLine();



        }
    }
}
