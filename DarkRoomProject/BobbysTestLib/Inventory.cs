using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    public class Inventory
    {
        public static List<Weapon> weaponslist = new List<Weapon>(); 

        public static void AddWeapons()
        {
            Weapon weapon = new Weapon();
            Console.WriteLine("Enter weapon name");
            weapon.Name = Console.ReadLine();//Gets info from the console
            Console.WriteLine("Is weapon throwable press Y for yes or N for no");
            if (Console.ReadLine() == "y")
            {
                weapon.Throwable = true;
                
            }
            else if (Console.ReadLine() == "n")
            {
                weapon.Throwable = false;
            }
            else
            {
                weapon.Throwable = false;
            }


            Console.WriteLine("Is Weapon breakable");
            if (Console.ReadLine() == "y")
            {
                weapon.Breakable = true;
            }
            else if (Console.ReadLine() == "n")
            {
                weapon.Breakable = false;
            }
            else
            {
                weapon.Breakable = false;
            }


            Console.WriteLine("Is weapon reloadable");
            if (Console.ReadLine() == "y")
            {
                weapon.Realoable = true;
            }
            else if (Console.ReadLine() == "n")
            {
                weapon.Realoable = false;
            }
            else
            {
                weapon.Realoable = false;
            }



            Console.WriteLine("How much does this weapon weight");
            weapon.Weight = Convert.ToInt32(Console.ReadLine());



           Console.WriteLine("How much ammo is left");
            weapon.AmmoCount = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("How much time");
            weapon.Timer = Convert.ToInt32(Console.ReadLine());


            weaponslist.Add(weapon);
            Console.WriteLine("Do u want to add another weapon");
              if (Console.ReadLine() == "y")
              {
                AddWeapons();


              }

                

            
            

           

           



               

        }

           
            
    }
}
