using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    public class Enemy : Character
    {
        public bool CanFlee = false;
        public int ExpReward { get; set; }
       
      
        
        
        
       /// <summary>
       /// 
       /// </summary>
       /// <param name="character"></param>
        public void ClawSlash(Character character)
        {
            int attackAmount = -30;
            StaminaDamageAdjust(ref attackAmount, AttackType.Medium);
            character.Health += attackAmount;
            Console.WriteLine($" { Name} Hit { character.Name} with a claw slash For {attackAmount} Damage ");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="character"></param>
        public void HeavySlash(Character character)
        {
            int attackAmount = -60;
            StaminaDamageAdjust(ref attackAmount, AttackType.Heavy);
            character.Health += attackAmount;
            Console.WriteLine($"{Name} Hit {character.Name} with a HeavySlash for {attackAmount}");
        }


       
        /// <summary>
        /// 
        /// </summary>
        public void Main()
        {
            List<Enemy> enemies = new List<Enemy>();
            Player Jack = new Player();

            enemies.Add(new Enemy() { Name = "Tiger", Health = 100, Stamina = 70  }  );

            enemies.Add(new Enemy() { Name = "Gorilla", Health = 200, Stamina = 60 } );

            enemies.Add(new Enemy()
            {
                Name = "VampireBat",
                Health = 50,
                Stamina = 100,
                PrimaryWeapon = new Weapon() {Name = "Scream", Damage = -30}
            });
            
            enemies.Add(new Enemy() { Name = "Goblin",
                                     Health = 150,
                                     Stamina = 50  } );
            enemies.Add(new Enemy() { Name = "Troll",
                                     Health = 200,
                                     Stamina = 30} );
            Jack.PrimaryWeaponAttack(enemies[0]);
            Jack.PrimaryWeaponAttack(enemies[1]);
            enemies[0].PrimaryWeaponAttack(Jack);
            enemies[1].PrimaryWeaponAttack(Jack);
            
            Console.WriteLine();



        }
    }
}
