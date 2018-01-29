using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
   public class InvetoryList
    {
        public ObtanableItem InventoryItem { get; set; }
        public int ItemAmount { get; set; }

        public InvetoryList(ObtanableItem item, int Amount)
        {
            InventoryItem = item;
            ItemAmount = Amount;
        }
        public void AddToAmount(int AmountToAdd)
        {
            ItemAmount += AmountToAdd;
        }
    }
    
}
