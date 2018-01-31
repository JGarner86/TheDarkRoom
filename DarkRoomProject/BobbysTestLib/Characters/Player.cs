using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    /// <summary>
    /// Proprties For Player
    /// </summary>
    public class Player : Character
    {
        public Inventory PlayerInventory { get; set; }
        public int ExpPoints { get; set; }
        public int FleeCount { get; set; } = 3;
        public int SwordSlashDamageAmount
        {
            get { return _swordSlashDamageAmount; }
            set { _swordSlashDamageAmount = value; }
        }

        public Player()
        {
            PlayerInventory = new Inventory();
        }

        /// <summary>
        /// 
        /// </summary>
        public int FinalSlashDamageAmount
        { 
            get { return _swordSlashDamageAmount; }
            set { _finalSlashDamageAmount = value; }
        }
        private int _finalSlashDamageAmount;
        private int _swordSlashDamageAmount;

        /// <summary>
        /// SwordSlash Damage Amount
        /// </summary>
        /// <param name="character"></param>
        public void SwordSlash(Character character)
        {
           int attackAmount = -40;
           StaminaDamageAdjust(ref _swordSlashDamageAmount, AttackType.Medium);
           character.Health += attackAmount;
           Console.WriteLine($"{Name} Hit {character.Name} with SwordSlash for{attackAmount}damage");
        }

        /// <summary>
        /// FinalSlash Damage Amount
        /// </summary>
        /// <param name="character"></param>
       public void FinalSlash (Character character)
       {
            int attackAmount = -80;
            StaminaDamageAdjust(ref _finalSlashDamageAmount, AttackType.Heavy);
            Health += attackAmount;
            Console.WriteLine($"{character.Name} Hit {Name} with a FinalSlash for{attackAmount}");          
       }


       public static void RunTestCode()
        {
            Player john = new Player()
            {
                Name = "John",
                
            };

            Potion healthPotion = new Potion("Health Potion");

            john.PlayerInventory.AddItem(healthPotion, 5);

            Console.WriteLine($"{john.Name} has {john.PlayerInventory.Count(healthPotion)} {healthPotion.Name}");

            john.PlayerInventory.AddItem(healthPotion, 2);

            Console.WriteLine($"{john.Name} has {john.PlayerInventory.Count(healthPotion)} {healthPotion.Name}");

            john.PlayerInventory.AddItem(healthPotion, 5);
            Console.WriteLine($"{john.Name} has {john.PlayerInventory.Count(healthPotion)} {healthPotion.Name}");
        }
       
    }
}
