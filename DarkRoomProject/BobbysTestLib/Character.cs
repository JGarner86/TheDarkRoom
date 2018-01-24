using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
   public class Character 
    {   public enum AttackType {Light,Medium,Heavy}
        public enum FromTo {BearToPlayer,PlayerToBear}
        public string Name { get; set; }
        public Weapon PrimaryWeapon; 
        public Weapon SecondaryWeapon = new Weapon();
        public Weapon Sidearm = new Weapon();
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Potion { get; set; }

        public Character()
        {
               
        }
        public Character(string _name, Weapon _primaryWeapon)
        {
            PrimaryWeapon = _primaryWeapon;
            Name = _name;
        }


       public void DamageAdjust(ref int damage)
       {
            damage = Stamina * damage / 100;
            Stamina -= 10;

       }
      
       
        public void PrimaryWeaponAttack(Bear bear, Player player, FromTo fromTo)
        {
            if(fromTo == FromTo.BearToPlayer)
            {
                player.Health += bear.PrimaryWeapon.Damage;
                Console.WriteLine($"{bear.Name} Hit {player.Name} With {bear.PrimaryWeapon.Name} for  {bear.PrimaryWeapon.Damage} damage");
            }
            if(fromTo == FromTo.PlayerToBear)
            {
                bear.Health += player.PrimaryWeapon.Damage;
                Console.WriteLine($"{player.Name} Hit {bear.Name} with {player.PrimaryWeapon.Name} for {player.PrimaryWeapon.Damage} damage" );
                
            }
           
        }
        public void SecondaryWeaponAttack(Bear bear, Player player, FromTo fromTo)
        {
            if (fromTo == FromTo.BearToPlayer)
            {
                player.Health += bear.SecondaryWeapon.Damage;
                Console.WriteLine($"{bear.Name} Hit {player.Name} With {bear.SecondaryWeapon.Name} for  {bear.SecondaryWeapon.Damage} damage");
            }
            if (fromTo == FromTo.PlayerToBear)
            {
                bear.Health += player.SecondaryWeapon.Damage;
                Console.WriteLine($"{player.Name} Hit {bear.Name} with {player.SecondaryWeapon.Name} for {player.SecondaryWeapon.Damage} damage");

            }

        }
        public void SidearmWeaponAttack(Bear bear, Player player, FromTo fromTo)
        {
            if (fromTo == FromTo.BearToPlayer)
            {
                player.Health += bear.Sidearm.Damage;
                Console.WriteLine($"{bear.Name} Hit {player.Name} With {bear.Sidearm.Name} for  {bear.Sidearm.Damage} damage");
            }
            if (fromTo == FromTo.PlayerToBear)
            {
                bear.Health += player.Sidearm.Damage;
                Console.WriteLine($"{player.Name} Hit {bear.Name} with {player.Sidearm.Name} for {player.Sidearm.Damage} damage");

            }

        }
        public void Healing( Bear bear)
        {
            bear.Stamina = 100;
            bear.Health += bear.Potion;
            Console.WriteLine($"{bear.Name} Drinks a potion and gains {bear.Potion} health");
        }
        public void Healing(Player player)
        {
            player.Stamina = 100;
            player.Health += player.Potion;
            Console.WriteLine($"{player.Name} Drinks a Potion and gains {player.Potion} health");

        }

    }
}
