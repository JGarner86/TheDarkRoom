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

        public const int MaxSlotsInInventory = 15;
        public readonly List<InvetoryList> InventoryList = new List<InvetoryList>();
        public void AddItem(ObtanableItem item, int AmountToAdd )
        {
            while (AmountToAdd > 0)
            {
                if (InventoryList.Exists(listitem => (listitem.ID == item.ID) && (AmountToAdd < item.StackableAmount)))
                {
                    InvetoryList invetoryList = InventoryList.First(listitem => (listitem.ID == item.ID) && (AmountToAdd < item.StackableAmount));
                    int MaxAmountPerStack = (item.StackableAmount - invetoryList.ItemAmount);
                    int AmountToAddPerStack = Math.Min(AmountToAdd, MaxAmountPerStack);
                    invetoryList.AddToAmount(AmountToAddPerStack);
                    AmountToAdd -= AmountToAddPerStack;
                }
                else
                {
                    if (InventoryList.Count < MaxSlotsInInventory)
                    {
                        InventoryList.Add(new InvetoryList(item, 0));
                    }
                    else
                    {
                        throw new Exception("You Are Out Of Inventory Space");
                    }
                }
            }
        }        
         
         

         
        
       

         
       
            
          
             
       public int Weapoms { get; set; }
       public int Consumables { get; set; }
       public int Wearables { get; set; }
       public int Ammo { get; set; }


    }
     
                        
}
  