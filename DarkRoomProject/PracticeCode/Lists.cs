using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    public class Lists
    {
       
        public string Name { get; set; }
        public int Age { get; set; }
        /// <summary>
        /// This will be the method called in program to run your test, so put the code that you want to run in here, then call it in program.cs
        /// </summary>
        public static void RunCode()
        {
            List<string> Name = new List<string>();
            
            {

                Name.Add("Josh");
                Name.Add("Matt");
                Name.Add("John");
            }

            List<Item> ItemList = new List<Item>()
            {
                new Item() {ItemId = 1, ItemName = "HealingPotion"},
                new Item() {ItemId = 2, ItemName = "StamminaPotion"},
                new Item() {ItemId = 3, ItemName = "StrengthPotion" }
                

            };


             Console.WriteLine("Number Of Names:{0}", Name.Count);


        }
    }
  
        
    

    

}
