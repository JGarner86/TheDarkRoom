using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    class Inventory
    {
        //properties for inventory
        public int Weight { get; set; }
        public string Name { get; set; }
        public bool HasOwner { get; set; }
        public string OwnersName { get; set; }
        public int empty { get; set; }



       public enum Tool { guns, structures, cars, pmodel, emodel,   }


    }
}
