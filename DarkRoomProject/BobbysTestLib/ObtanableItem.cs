using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
   public class ObtanableItem
    {
    

        public Guid ID { get; set; }
        public string Name { get; set; }
        public int StackableAmount { get; set; }

        protected ObtanableItem()
        {
            StackableAmount = 1;
            

        }

    }
   
}
