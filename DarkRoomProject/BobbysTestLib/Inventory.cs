using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{    /// <summary>
     /// Properties For Inventory
     /// </summary>
    public class Inventory
    {
        public int Weapoms { get; set; }
        public int Consumables { get; set; }
        public int Wearables { get; set; }
        public int Ammo { get; set; }
        public const int MaxSlotsInInventory = 15;
        public readonly List<InventoryItem> InventoryList = new List<InventoryItem>();



        public void AddItem(ObtanableItem item, int AmountToAdd )
        {
            while (AmountToAdd > 0)
            {
                if (InventoryList.Exists(listitem => (listitem.ID == item.ID) && (AmountToAdd < item.StackableAmount)))
                {
                    InventoryItem invetoryList = InventoryList.First(listitem => (listitem.ID == item.ID) && (AmountToAdd < item.StackableAmount));
                    int MaxAmountPerStack = (item.StackableAmount - invetoryList.ItemAmount);
                    int AmountToAddPerStack = Math.Min(AmountToAdd, MaxAmountPerStack);
                    invetoryList.AddToAmount(AmountToAddPerStack);
                    AmountToAdd -= AmountToAddPerStack;
                }
                else
                {
                    if (InventoryList.Count < MaxSlotsInInventory)
                    {
                        InventoryList.Add(new InventoryItem(item, 0));
                    }
                    else
                    {
                        throw new Exception("You Are Out Of Inventory Space");
                    }
                }
            }
        }        
         
        public int Count(ObtanableItem item)
        {
            return InventoryList.Find(x => x.ID == item.ID).ItemAmount;
        }

         
        
       

         
       
            
          
             
       


    }
     
                        
}
  