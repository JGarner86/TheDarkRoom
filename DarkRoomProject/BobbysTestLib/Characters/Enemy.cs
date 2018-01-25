using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    public class Enemy : Character
    {   /// <summary>
        /// Proprites For Enemy
        /// </summary>
        public bool CanFlee = false;
        public int ExpReward { get; set; }
        public int ClawSlashDamageAmount
        {
            get { return _clawSlash; }
            set { _clawSlash = value;  }

        }

        /// <summary>
        /// 
        /// </summary>
        public int HeavySlashDamageAmount
        {
            get { return _heavySlash; }
            set { _heavySlash = value; }

        }


        private int _clawSlash;
        private int _heavySlash;
       
      
        
        
        
       /// <summary>
       /// 
       /// </summary>
       /// <param name="character"></param>
        public void ClawSlash(Character character)
        {
            int attackAmount = -30;
            StaminaDamageAdjust(ref _clawSlash, AttackType.Medium);
            character.Health += attackAmount;
            Console.WriteLine($" {Name} Hit {character.Name} with a claw slash For {attackAmount} Damage ");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="character"></param>
        public void HeavySlash(Character character)
        {
            int attackAmount = -60;
            StaminaDamageAdjust(ref _heavySlash, AttackType.Heavy);
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

            enemies.Add(new Enemy() { Name = "Tiger",
                Health = 100,
                Stamina = 70,
                PrimaryWeapon = new Weapon() { Name = "Slash", Damage = -45 },
                SecondaryWeapon = new Weapon() { Name = "Bite", Damage = -25 },


            });

            enemies.Add(new Enemy()
            { Name = "Gorilla",
                Health = 200,
                Stamina = 60,
                PrimaryWeapon = new Weapon() { Name = "Haymaker", Damage = -40 },
                SecondaryWeapon = new Weapon() { Name = "GroundPound", Damage = -30 }


            });

            enemies.Add(new Enemy()
            {
                Name = "VampireBat",
                Health = 50,
                Stamina = 100,
                PrimaryWeapon = new Weapon() { Name = "Scream", Damage = -15 },
                SecondaryWeapon = new Weapon() { Name = "Bite", Damage = -10 }
            });

            enemies.Add(new Enemy()
            {
                Name = "Goblin",
                Health = 150,
                Stamina = 50,
                PrimaryWeapon = new Weapon() { Name = "ClubSwing", Damage = -35 },
                SecondaryWeapon = new Weapon() { Name = "RockThrow", Damage = -25 }
            });


            



            enemies.Add(new Enemy()
            { Name = "Troll",
              Health = 200,
              Stamina = 30,
              PrimaryWeapon = new Weapon() { Name = "SpearJaust", Damage = -35},
              SecondaryWeapon = new Weapon() { Name = "SpearThrow", Damage = -25}

            } );



            Jack.PrimaryWeaponAttack(enemies[0]);
            Jack.PrimaryWeaponAttack(enemies[1]);
            enemies[0].PrimaryWeaponAttack(Jack);
            enemies[1].PrimaryWeaponAttack(Jack);
            
            Console.WriteLine();



        }
    }
}
