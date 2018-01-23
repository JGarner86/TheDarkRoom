using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
   public class Character 
    { 
       string Name { get; set; }
        public Weapon PrimaryWeapon; 
        public Weapon SecondaryWeapon = new Weapon();
        public Weapon Sidearm = new Weapon();
        public int Health { get; set; }

        public Character()
        {
               
        }
        public Character(string _name, Weapon _primaryWeapon)
        {
            PrimaryWeapon = _primaryWeapon;
            Name = _name;
        }
        
      
       
        

    }
}
