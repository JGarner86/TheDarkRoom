using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
   public class InventoryItem : ObtanableItem
    {
        public ObtanableItem Item { get; private set; }
        public int ItemAmount { get; private set; }

        public InventoryItem(ObtanableItem item, int Amount)
        {
            Item = item;
            ItemAmount = Amount;
        }
        public void AddToAmount(int AmountToAdd)
        {
            ItemAmount += AmountToAdd;
        }
    }
    
}
