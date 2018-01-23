using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
   public class Character 
    { 
        public string Name { get; set; }
        public Weapon PrimaryWeapon; 
        public Weapon SecondaryWeapon = new Weapon();
        public Weapon Sidearm = new Weapon();
        public int Health { get; set; }
        public int Stamina { get; set; }

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
      
       
        

    }
}
