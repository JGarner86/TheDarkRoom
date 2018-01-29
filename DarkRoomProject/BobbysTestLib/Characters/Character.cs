using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{   /// <summary>
    /// Propites For Character
    /// </summary>
   public class Character 
    {   public enum AttackType {Light,Medium,Heavy,Ultra }
        public enum FromTo {BearToPlayer,PlayerToBear}
        public string Name { get; set; }
        public Weapon PrimaryWeapon;
        public Weapon SecondaryWeapon;
        public Weapon Sidearm;
        public Weapon Special;
        public int Health { get; set; }
        public int Stamina { get; set; }   
        public int StaminaReginFactor { get; set; }
        public int Damage { get; set; }
        public bool BlockDamage { get; set; }
        public int GoldAmount { get; set; }
        public int Level { get; set; }
        public Potion consumable;
        
        
        
        
        
       
        

        public Character()
        {
               
        }




        public Character(string _name, Weapon _primaryWeapon)
        {
            PrimaryWeapon = _primaryWeapon;
            Name = _name;
        }

        /// <summary>
        /// Changes the damage output based off attack type 
        /// </summary>
        /// <param name="damage"></param>
        /// <param name="attackType"></param>
       public void StaminaDamageAdjust(ref int damage,AttackType attackType)
       {
            switch (attackType)
            {
                case AttackType.Light:
                    damage = Stamina * damage / 100;
                    Stamina -= 2;
                    break;
                case AttackType.Medium:
                    damage = Stamina * damage / 100;
                    Stamina -= 10;
                    break;
                case AttackType.Heavy:
                    damage = Stamina * damage / 100;
                    Stamina -= 15;
                    break;
            }
            
           

       }
      
      /// <summary>
      /// 
      /// </summary>
      /// <param name="character"></param>
        public void PrimaryWeaponAttack(Character character)
        {
            
               character.Health += PrimaryWeapon.Damage;
                Console.WriteLine($"{Name} Hit {character.Name} With {PrimaryWeapon.Name} for  {PrimaryWeapon.Damage} damage");
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="character"></param>
        public void SecondaryWeaponAttack(Character character)
        {
            
            
                character.Health += SecondaryWeapon.Damage;
                Console.WriteLine($"{Name} Hit {character.Name} With {SecondaryWeapon.Name} for  {SecondaryWeapon.Damage} damage");
         }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="character"></param>
        public void SidearmWeaponAttack(Character character )
        {
          
                character.Health += Sidearm.Damage;
                Console.WriteLine($"{Name} Hit {character.Name} With {Sidearm.Name} for  {Sidearm.Damage} damage");   
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="character"></param>
        public void Healing(Character character)
        {
            Stamina = 100;
            //Health += consumable.Potion;
            //Console.WriteLine($"{Name} Drinks a potion and gains {consumable.Potion} health");
        }
       
        ///
        public void StaminaRegin(Character character )
        {
           character.Stamina += character.StaminaReginFactor;
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bear"></param>
        public void PowerUp()
        {
            int defenseUp = 40;
            Health += defenseUp;
            Console.WriteLine($"{Name} used agro to Power Up {defenseUp}");
        }
       
    }
}
